using HUD;
using UnityEngine;

public class ResourceGain : MonoBehaviour
{
    //To Do List
    //1. Function to increase resource gain from clicking by x %
    //2. Function to increase resource gain from employees (automatic) by x %

    public Resource resource;
    public Employee employee;
    public UpgradesUI currentUpgrades;
    public int employeeLevel = 1;
    public int clickLevel = 1;
    
    public int amount;

    public void ClickUpgrade()
    {
        resource.amountPerClick += amount * clickLevel;
        clickLevel++;
        currentUpgrades.UpdateData();
    }

    public void EmployeeUpgrade()
    {
        employee.ProductionAmount += amount * employeeLevel;
        employeeLevel++;
        currentUpgrades.UpdateData();
    }
}

