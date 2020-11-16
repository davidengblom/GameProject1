using System;
using System.Security.AccessControl;
using UnityEngine;
using UnityEngine.UI;
using Upgrades.Character;

namespace HUD
{
    public class ExperienceUI : MonoBehaviour
    {
        [SerializeField] Image expImage;
        [SerializeField] Text expText;

        public Experience _experience;

        void Start()
        {
            UpdateExpImage(this._experience.employeeType);
            UpdateExpText(this._experience.employeeType);
        }

        void Update()
        {
            UpdateExpImage(this._experience.employeeType);
            UpdateExpText(this._experience.employeeType);
        }

        void UpdateExpImage(EmployeeType resourceType)
        {
            if (resourceType != this._experience.employeeType) return;
            this.expImage.fillAmount = this._experience.ExperiencePoints / this._experience.ExperienceToNextLevel;
        }

        void UpdateExpText(EmployeeType resourceType)
        {
            if (resourceType != this._experience.employeeType) return;
            this.expText.text = $"Level: {this._experience.CurrentLevel}       Exp to next level: {this._experience.ExperiencePoints} / {this._experience.ExperienceToNextLevel}";
        }
    }
}