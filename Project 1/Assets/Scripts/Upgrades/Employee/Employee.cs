using System;
using UnityEngine;
using Upgrades.Character;

namespace Upgrades.Employee
{
    [Serializable]
    public class Employee
    {
        public EmployeeType type;
        public float productionTime;
        [HideInInspector] public float timer;
        public Resource resource;

        public bool ShouldProduce => Time.time - this.timer > this.productionTime;
    }
}