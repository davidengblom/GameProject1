using UnityEngine;

public class ResourceGain : MonoBehaviour
{
    //To Do List
    //1. Function to increase resource gain from clicking by x %
    //2. Function to increase resource gain from employees (automatic) by x %

    public Resource resource;
    public Employee employee;
    public float clickPercent;
    public float employeePercent;

    public void ClickUpgrade()
    {
        resource.amountPerClick = (int) (resource.amountPerClick * clickPercent);
        //Update the data text on Upgrades UI
    }

    public void EmployeeUpgrade()
    {
        employee.productionAmount = (int) (employee.productionAmount * employeePercent);
        //Update the data text on Upgrades UI
    }
}

