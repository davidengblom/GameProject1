using System;
using UnityEngine;
using UnityEngine.UI;

namespace Upgrades.Housing
{
    public class Housing : MonoBehaviour
    {
        public Purchasable purchasable;
        public Text costText;

        public float costIncrementPercent = 50;
        Hire _hire;

        public void UpgradeEmployeeCap()
        {
            if (this.purchasable.resource.Owned < CurrentCost()) return;
            CurrentCost();
            this._hire.EmployeeCap += 1;
            this.costText.text = CurrentCost().ToString();
        }

        float Cost
        {
            get => PlayerPrefs.GetFloat("Cost" + this.name, this.purchasable.cost);
            set => PlayerPrefs.SetFloat("Cost" + this.name, value);
        }

        int CurrentCost()
        {
            this.Cost *= 1 + (this.costIncrementPercent / 100);
            return (int) this.Cost;
        }
    }
}