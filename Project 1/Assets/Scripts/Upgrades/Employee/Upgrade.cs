using System;
using UnityEngine;
using Upgrades.Character;

namespace Upgrades.Employee
{
    [Serializable]
    public class Upgrade
    {
        public EmployeeType type;

        public AutomaticProduction autoProductions;
        
        public int Amount
        {
            get => PlayerPrefs.GetInt("Upgrade" + this.type, 0);
            set => PlayerPrefs.SetInt("Upgrade" + this.type, value);
        }
        
        public float AssignAmount(EmployeeType type)
        {
            if (this.type != type) return 0;
            var autoProd = this.autoProductions;
            return this.Amount += autoProd.ResourceAmountPerSecond();
        }
    }
}
