using System;
using UnityEngine;

namespace Upgrades.Character
{
    [Serializable]
    public class Experience
    {
        [Tooltip("How much should max level exp requirement increment per level?")]
        public int incrementFactorPerLevel = 2;
        public int baseExpRequirement = 10;
        public EmployeeType employeeType;

        public int ExperiencePoints
        {
            get => PlayerPrefs.GetInt("CurrentExperience" + this.employeeType, 0);
            set => PlayerPrefs.SetInt("CurrentExperience" + this.employeeType, value);
        }

        public float ExperienceToNextLevel
        {
            get => PlayerPrefs.GetFloat("ExpToNextLevel" + this.employeeType, this.baseExpRequirement);
            set => PlayerPrefs.SetFloat("ExpToNextLevel" + this.employeeType, value);
        }

        public int CurrentLevel
        {
            get => PlayerPrefs.GetInt("CurrentLevel" + this.employeeType, 1);
            set => PlayerPrefs.SetInt("CurrentLevel" + this.employeeType, value);
        }

        public void GainExperience(int amountToGain, EmployeeType employeeType)
        {
            this.employeeType = employeeType;
            if (this.employeeType == employeeType)
            {
                this.ExperiencePoints += amountToGain;
                HasLeveledUp(this.employeeType);
            }
        }

        void HasLeveledUp(EmployeeType employeeType)
        {
            if (this.employeeType != employeeType) return;
            if (!(this.ExperiencePoints >= this.ExperienceToNextLevel)) return;
            this.ExperienceToNextLevel *= this.incrementFactorPerLevel;
            this.ExperiencePoints = 0;
            this.CurrentLevel++;
        }
    }
}