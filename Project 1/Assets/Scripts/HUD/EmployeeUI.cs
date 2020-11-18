using UnityEngine;
using UnityEngine.UI;

namespace HUD
{
    [RequireComponent(typeof(OverviewPanelReference))]
    public class EmployeeUI : MonoBehaviour, IReset
    {
        //TODO retrieve data how many employees player has
        //TODO retrieve data on level (and current EXP/progress bar?) the player has
        public Purchasable purchaseMiner;
        public Purchasable purchaseLumberjack;
        public Purchasable purchaseHunter;
        public Text ownedEmployersText;

        public Hire hunter;
        public Hire miner;
        public Hire lumberJack;


        void Start()
        {
            OwnedEmployeesUI();
        }

        void OwnedEmployeesUI()
        {
            this.ownedEmployersText.text = $"Current owned {this.miner.EmployeeUnit} miner(s), {this.lumberJack.EmployeeUnit} lumberjack(s), {this.hunter.EmployeeUnit} hunter(s)";
        }


        public void PurchaseMiner()
        {
            if (!this.purchaseMiner.IsAffordable() || miner.CheckIfCap()) return;
            this.purchaseMiner.resource.Owned -= this.purchaseMiner.cost;
            this.miner.EmployeeUnit++;
            OwnedEmployeesUI();
        }

        public void PurchaseLumberjack()
        {
            if (!this.purchaseLumberjack.IsAffordable() || lumberJack.CheckIfCap()) return;
            this.purchaseLumberjack.resource.Owned -= this.purchaseLumberjack.cost;
            this.lumberJack.EmployeeUnit++;
            OwnedEmployeesUI();
        }

        public void PurchaseHunter()
        {
            if (!this.purchaseHunter.IsAffordable() || hunter.CheckIfCap()) return;
            this.purchaseHunter.resource.Owned -= this.purchaseHunter.cost;
            this.hunter.EmployeeUnit++;
            OwnedEmployeesUI();
        }

        public void Reset()
        {
            this.hunter.EmployeeUnit = 0;
            this.miner.EmployeeUnit = 0;
            this.lumberJack.EmployeeUnit = 0;
            OwnedEmployeesUI();
        }
    }
}