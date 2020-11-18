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

        public Upgrade hunterUpgrade, lumberUpgrade, minerUpgrade;
        
        public Resource stone, wood, food;

        private void Start()
        {
            UpdateData();
        }

        public void UpdateData()
        {
            this.currentUpgradesText.text =
                $"{this.hunterUpgrade.autoProductions.ResourceAmountPerSecond()} Food /s, {this.lumberUpgrade.autoProductions.ResourceAmountPerSecond()} Wood /s, {this.minerUpgrade.autoProductions.ResourceAmountPerSecond()} Stone /s";
            
            this.currentClickUpgradesText.text =
                $"{this.food.ClickLevel} Food per click, {this.wood.ClickLevel} Wood per click, {this.stone.ClickLevel} Stone per click";
        }
    }
}
