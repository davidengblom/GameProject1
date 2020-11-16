using System;
using UnityEngine;
using UnityEngine.UI;

namespace HUD
{
    public class UpgradesUI : MonoBehaviour
    {
        public Text currentUpgradesText;
        public Text currentClickUpgradesText;

        public Text employeeLevel;
        public Text clickLevel;

        public Employee hunter;
        public Employee lumberjack;
        public Employee miner;

        public Resource stone;
        public Resource wood;
        public Resource food;

        private void Start()
        {
            UpdateData();
        }

        public void UpdateData()
        {
            // this.currentUpgradesText.text =
            //     $"{this.hunter.ProductionAmount} per Hunter, {this.lumberjack.ProductionAmount} per Lumberjack, {this.miner.ProductionAmount} per Miner";
            //
            // this.currentClickUpgradesText.text =
            //     $"{this.food.amountPerClick} Food per click, {this.wood.amountPerClick} Wood per click, {this.stone.amountPerClick} Stone per click";
        }
    }
}
