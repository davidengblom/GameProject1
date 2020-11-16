using System;
using UnityEngine;
using UnityEngine.UI;

namespace HUD
{
    public class UpgradesUI : MonoBehaviour
    {
        public Text currentUpgradesText;

        public Employee hunter;
        public Employee lumberjack;
        public Employee miner;

        private void Start()
        {
            UpdateData();
        }

        public void UpdateData()
        {
            currentUpgradesText.text =
                $"{hunter.ProductionAmount} per Hunter, {lumberjack.ProductionAmount} per Lumberjack, {miner.ProductionAmount} per Miner";
        }
    }
}
