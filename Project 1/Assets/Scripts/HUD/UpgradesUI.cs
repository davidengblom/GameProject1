using System;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;
using Upgrades.Character;
using Upgrades.Employee;

namespace HUD
{
    public class UpgradesUI : MonoBehaviour
    {
        public Text currentUpgradesText;
        public Text currentClickUpgradesText;

        public Text employeeLevel;
        public Text clickLevel;

        private AutomaticProduction[] _automaticProductions;

        private int[] _amountText = new int[3];

        public Upgrade hunterUpgrade, lumberUpgrade, minerUpgrade;
        
        public Resource stone, wood, food;
        public Employee hunter, miner, lumberjack;

        private void Start()
        {
            this._automaticProductions = FindObjectsOfType<AutomaticProduction>();
            UpdateData();
        }

        public void UpdateData()
        {
            this.currentUpgradesText.text =
                $"{this.hunterUpgrade.AssignAmount(EmployeeType.Hunter)} per Hunter, {this.lumberUpgrade.AssignAmount(EmployeeType.Lumberjack)} per Lumberjack, {this.minerUpgrade.AssignAmount(EmployeeType.Miner)} per Miner";
            
            this.currentClickUpgradesText.text =
                $"{this.food.amountPerClick} Food per click, {this.wood.amountPerClick} Wood per click, {this.stone.amountPerClick} Stone per click";
        }
    }
}
