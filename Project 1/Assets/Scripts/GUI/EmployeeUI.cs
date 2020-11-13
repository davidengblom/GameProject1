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
        public Purchasable _purchasable;
        public Text ownedEmployersText;
        public Purchasable onClick;

        int minersOwned;
        int lumberjacksOwned;
        int huntersOwned;

        void Start()
        {
            this.OwnedEmployeesUI();
        }

        public void OwnedEmployeesUI()
        {
            this.ownedEmployersText.text = $"Current owned {this.minersOwned} miner(s), {this.lumberjacksOwned} lumberjack(s), {this.huntersOwned} hunter(s)";
        }


        public void PurchaseMiner()
        {
            if (!this._purchasable.IsAffordable() && this._purchasable.resource.name == "Gold") return;
            this._purchasable.resource.Owned -= this._purchasable.cost;
            this.minersOwned++;
            this.OwnedEmployeesUI();
        }

        public void PurchaseLumberjack()
        {
            if (!this._purchasable.IsAffordable()) return;
            this._purchasable.resource.Owned -= this._purchasable.cost;
            this.lumberjacksOwned++;
            this.OwnedEmployeesUI();
        }

        public void PurchaseHunter()
        {
            if (!this._purchasable.IsAffordable()) return;
            this._purchasable.resource.Owned -= this._purchasable.cost;
            this.huntersOwned++;
            this.OwnedEmployeesUI();
        }

        public void Produce()
        {
            this.onClick.resource.Produce();
            print(this.onClick.resource.Owned + "   " + this.onClick.resource.name);
        }
    }
}