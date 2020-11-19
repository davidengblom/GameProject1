using System;
using HUD;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Upgrades.Employee
{
    public class PurchaseUpgrade : MonoBehaviour, IPointerClickHandler
    {
        public Purchasable purchasable;
        public Resource resourceToProduce;
        public int multiplier;
        public float costPercentIncrease;

        public Text costText;
        public AutomaticProduction autoProd;
        private UpgradesUI _ui;

        private float CostMultiplier
        {
            get => PlayerPrefs.GetFloat("CostMultiplier" + this.name, this.purchasable.cost);
            set => PlayerPrefs.SetFloat("CostMultiplier" + this.name, value);
        }

        private void Start()
        {
            this._ui = FindObjectOfType<UpgradesUI>();
            UpdateCostText();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (this.purchasable.resource.Owned - this.CostMultiplier >= 0)
            {
                this.purchasable.resource.Owned -= (int) this.CostMultiplier;
                this.CostMultiplier *= (this.costPercentIncrease / 100 + 1);
                this.autoProd.ProductionMultiplier += this.multiplier;
                this.resourceToProduce.ClickLevel += this.multiplier;
                UpdateCostText();
                this._ui.UpdateData();
            }
            
        }
        private void UpdateCostText() => this.costText.text = "Cost" + " " + (int) this.CostMultiplier + " " + this.purchasable.resource.name;
    }
}
