using System;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace GUI
{
    public class EmployeeUI : MonoBehaviour
    {
        //TODO retrieve data how many employees player has
        //TODO retrieve data on level (and current EXP/progress bar?) the player has
        public Purchasable purchaseMiner;
        public Purchasable purchaseLumberjack;
        public Purchasable purchaseHunter;
        public Text ownedEmployersText;

        int minersOwned;
        int lumberjacksOwned;
        int huntersOwned;

        void Start()
        {
            this.OwnedEmployeesUI();
        }

        void OwnedEmployeesUI()
        {
            this.ownedEmployersText.text = $"Current owned {this.minersOwned} miner(s), {this.lumberjacksOwned} lumberjack(s), {this.huntersOwned} hunter(s)";
        }


        public void PurchaseMiner()
        {
            if (!this.purchaseMiner.IsAffordable()) return;
            this.purchaseMiner.resource.Owned -= this.purchaseMiner.cost;
            this.minersOwned++;
            this.OwnedEmployeesUI();
        }

        public void PurchaseLumberjack()
        {
            
            if (!this.purchaseLumberjack.IsAffordable()) return;
            this.purchaseLumberjack.resource.Owned -= this.purchaseLumberjack.cost;
            this.lumberjacksOwned++;
            this.OwnedEmployeesUI();
            
        }

        public void PurchaseHunter()
        {
            if (!this.purchaseHunter.IsAffordable()) return;
            this.purchaseHunter.resource.Owned -= this.purchaseHunter.cost;
            this.huntersOwned++;
            this.OwnedEmployeesUI();
        }
    }
}