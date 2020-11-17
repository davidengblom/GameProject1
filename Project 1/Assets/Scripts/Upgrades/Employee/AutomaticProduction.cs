using System;
using UnityEngine;
using UnityEngine.UI;
using Upgrades.Character;

namespace Upgrades.Employee
{
    public class AutomaticProduction : MonoBehaviour
    {
        public Employee employee;
        Text _text;

        void Start()
        {
            this._text = GetComponent<Text>();
        }

        void Update()
        {
            AmountToProduce();
        }

        public void AmountToProduce()
        {
            this.employee.AutoProduce();
            this._text.text = this.employee.resource.Owned.ToString();
        }
    }
}