using UnityEngine;

public class ResourceGain : MonoBehaviour
{
    //To Do List
    //1. Function to increase resource gain from clicking by x %
    //2. Function to increase resource gain from employees (automatic) by x %

    public Resource resource;
    public float percent;

    public void ClickUpgrade()
    {
        resource.amountPerClick = (int) (resource.amountPerClick * percent);
    }

    public void EmployeeUpgrade()
    {
            
    }
}
