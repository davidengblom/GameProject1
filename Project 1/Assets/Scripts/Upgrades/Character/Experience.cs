using System;
using UnityEngine;


namespace Upgrades.Character
{
    [Serializable]
    public class Experience
    {
        public int incrementFactorPerLevel = 2;
        
        
        public EmployeeType employeeType;

        int _currentLevel;
        int _experienceToNextLevel;
        public int ExperiencePoints
        {
            get => PlayerPrefs.GetInt("CurrentExperience" + this.employeeType, 0);
            set => PlayerPrefs.SetInt("CurrentExperience" + this.employeeType, value);
        }

        public int ExperienceToNextLevel
        {
            get => this._experienceToNextLevel;
            set => this._experienceToNextLevel = value;
        }

        public int CurrentLevel
        {
            get => PlayerPrefs.GetInt("CurrentLevel" + this.employeeType, 0);
            set => this._currentLevel = value;
        }
    }
}