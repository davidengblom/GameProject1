using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Upgrades.Character;

namespace Upgrades.Housing
{
    public class Housing : MonoBehaviour
    {
        public Purchasable purchasable;
        public Text costText;

        public float costIncrementPercent = 50;
        Hire _hire = new Hire();

        void Start()
        {
            this.costText.text = $"Increase the amount of employees hired by 1 \n Cost: {(int) this.Cost} {this.purchasable.resource.name}";
        }

        public void UpgradeEmployeeCap()
        {
            if (this.purchasable.resource.Owned < CurrentCost()) return;
            this.purchasable.resource.Owned -= CurrentCost();
            CurrentCost();
            this._hire.EmployeeCap += 1;
            this.costText.text = $"Increase the amount of employees hired by 1 \n Cost: {CurrentCost()} {this.purchasable.resource.name}";
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