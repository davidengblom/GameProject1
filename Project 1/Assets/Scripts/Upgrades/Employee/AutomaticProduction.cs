﻿using System;
using UnityEngine;
using UnityEngine.UI;
using Upgrades.Character;

namespace Upgrades.Employee
{
    public class AutomaticProduction : MonoBehaviour
    {
        public Employee employee;
        private Hire _hire = new Hire();
        Text _text;

        private void Start()
        {
            this._hire.employeeType = this.employee.type;
            this._text = GetComponent<Text>();
            AutoProduce();
            this._text.text = this.employee.resource.Owned.ToString();
        }

        void Update()
        {
            AutoProduce();
        }

        private void AutoProduce()
        {
            if (!this.employee.ShouldProduce) return;
            this.employee.timer = Time.time;
            this.employee.resource.Owned += ResourceAmountPerSecond();
            this._text.text = this.employee.resource.Owned.ToString();
        }

        public int ResourceAmountPerSecond()
        {
            return (this._hire.EmployeeUnit * 2) + (this.employee.resource.amountPerClick * this.employee.EmployeeLevel);
        }
    }
}