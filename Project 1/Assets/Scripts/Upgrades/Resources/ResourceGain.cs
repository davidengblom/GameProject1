using System;
using HUD;
using UnityEngine;
using Upgrades.Character;
using Upgrades.Employee;

public class ResourceGain : MonoBehaviour
{
    public EmployeeType type;

    public Resource resource;
    public Employee employee;
    public UpgradesUI currentUpgrades;
    
    public int employeeLevel = 1;
    public int clickLevel = 1;
    
    public int amount;

    private void Start()
    {
        this.employee.type = this.type;
    }

    private void Update()
    {
        //this.employee.AutoProduce(this.resource);
    }

    public void EmployeeUpgrade()
    {
        // if (this.type != this.employee.type) return;
        // this.employee.ProductionAmount += this.amount * this.employeeLevel;
        // this.employeeLevel++;
        // this.currentUpgrades.UpdateData();
    }
    
    public void Upgrade()
    {
        if (this.type != this.employee.type) return;
        this.resource.Owned += this.resource.amountPerClick * this.resource.ClickLevel;
        this.resource.ClickLevel++;
        this.currentUpgrades.UpdateData();
    }
}

