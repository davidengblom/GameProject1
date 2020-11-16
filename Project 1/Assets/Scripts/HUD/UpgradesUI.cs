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

        private void UpdateData()
        {
            currentUpgradesText.text =
                $"{hunter.productionAmount} per Hunter, {lumberjack.productionAmount} per Lumberjack, {miner.productionAmount} per Miner";
        }
    }
}
