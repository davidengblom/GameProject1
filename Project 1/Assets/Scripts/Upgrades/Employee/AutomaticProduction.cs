using System;
using UnityEngine;
using UnityEngine.UI;
using Upgrades.Character;

namespace Upgrades.Employee
{
    public class AutomaticProduction : MonoBehaviour
    {
        public Employee employee;
        public Hire _hire;
        Text _text;

        public int ProductionMultiplier
        {
            get => PlayerPrefs.GetInt("Multiplier" + this.employee.type, 2);
            set => PlayerPrefs.SetInt("Multiplier" + this.employee.type, value);
        }

        private void Start()
        {
            this._hire.employeeType = this.employee.type;
            this._text = GetComponent<Text>();
            this._text.text = this.employee.resource.Owned.ToString();
        }

        void Update()
        {
            AutoProduce();
        }

        private void AutoProduce()
        {
            if (!this.employee.ShouldProduce) return;
            this.employee.resource._experience.GainExperience(this.employee.resource.expGainPerClick * this._hire.EmployeeUnit, this.employee.type);
            this.employee.timer = Time.time;
            this.employee.resource.Owned += ResourceAmountPerSecond();
            this._text.text = this.employee.resource.Owned.ToString();
        }

        public int ResourceAmountPerSecond()
        {
            return (this._hire.EmployeeUnit * this.ProductionMultiplier);
        }
    }
}