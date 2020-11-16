using System;
using UnityEngine;


namespace Upgrades.Character
{
    public class Experience : MonoBehaviour
    {
        [Tooltip("How much should max level exp requirement increment per level?")]
        public int incrementFactorPerLevel = 2;

        public int baseExpRequirement = 10;

        public EmployeeType employeeType;

        int _experienceToNextLevel;

        public int ExperiencePoints
        {
            get => PlayerPrefs.GetInt("CurrentExperience" + this.employeeType, 0);
            set => PlayerPrefs.SetInt("CurrentExperience" + this.employeeType, value);
        }

        public float ExperienceToNextLevel() => (this.incrementFactorPerLevel * this.baseExpRequirement) * this.CurrentLevel;

        public int CurrentLevel
        {
            get => PlayerPrefs.GetInt("CurrentLevel" + this.employeeType, 1);
            set => PlayerPrefs.SetInt("CurrentLevel" + this.employeeType, value);
        }

        public void GainExperience(int amountToGain, EmployeeType employeeType)
        {
            this.employeeType = employeeType;
            this.ExperiencePoints += amountToGain;
            HasLeveledUp(this.employeeType);
        }

        void HasLeveledUp(EmployeeType employeeType)
        {
            if (this.employeeType != employeeType) return;

            if (!(this.ExperiencePoints >= ExperienceToNextLevel())) return;
            
            this.ExperiencePoints = 0;
            this.CurrentLevel++;
            print(this.CurrentLevel + "   " + employeeType);
        }
    }
}