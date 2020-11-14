using UnityEngine;
using UnityEngine.UI;

namespace GUI
{
    [RequireComponent(typeof(OverviewPanelReference))]
    public class EmployeeUI : MonoBehaviour
    {
        //TODO retrieve data how many employees player has
        //TODO retrieve data on level (and current EXP/progress bar?) the player has
        public Purchasable purchaseMiner;
        public Purchasable purchaseLumberjack;
        public Purchasable purchaseHunter;
        public Text ownedEmployersText;

        Hire _hire;

        void Start()
        {
            this._hire = FindObjectOfType<Hire>();
            OwnedEmployeesUI();
        }

        void OwnedEmployeesUI()
        {
            this.ownedEmployersText.text = $"Current owned {this._hire.Miner} miner(s), {this._hire.LumberJack} lumberjack(s), {this._hire.Hunter} hunter(s)";
        }


        public void PurchaseMiner()
        {
            if (!this.purchaseMiner.IsAffordable()) return;
            this.purchaseMiner.resource.Owned -= this.purchaseMiner.cost;
            this._hire.Miner++;
            OwnedEmployeesUI();
        }

        public void PurchaseLumberjack()
        {
            
            if (!this.purchaseLumberjack.IsAffordable()) return;
            this.purchaseLumberjack.resource.Owned -= this.purchaseLumberjack.cost;
            this._hire.LumberJack++;
            OwnedEmployeesUI();
            
        }

        public void PurchaseHunter()
        {
            if (!this.purchaseHunter.IsAffordable()) return;
            this.purchaseHunter.resource.Owned -= this.purchaseHunter.cost;
            this._hire.Hunter++;
            OwnedEmployeesUI();
        }
    }
}