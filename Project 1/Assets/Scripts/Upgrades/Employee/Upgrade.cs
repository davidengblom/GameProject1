using System;
using UnityEngine;
using Upgrades.Character;

namespace Upgrades.Employee
{
    [Serializable]
    public class Upgrade
    {
        public EmployeeType type;

        private AutomaticProduction[] _autoProductions = new AutomaticProduction[3];

        public int Amount
        {
            get => PlayerPrefs.GetInt("Upgrade" + this.type, 0);
            set => PlayerPrefs.SetInt("Upgrade" + this.type, value);
        }
        
        public float AssignAmount(EmployeeType type)
        {
            if (this.type != type) return 0;
            var autoProd = new AutomaticProduction();;
            return this.Amount += autoProd.ResourceAmountPerSecond();
        }
    }
}
