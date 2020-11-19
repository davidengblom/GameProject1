using UnityEngine;
using Upgrades.Character;

[System.Serializable]
public class Hire
{
    public EmployeeType employeeType;

    public int EmployeeUnit
    {
        get => PlayerPrefs.GetInt("EmployeeUnit" + employeeType, 0);
        set => PlayerPrefs.SetInt("EmployeeUnit" + employeeType, value);
    }

    public bool CheckIfCap()
    {
        return EmployeeUnit >= EmployeeCap;
    }

    public int EmployeeCap
    {
        get => PlayerPrefs.GetInt("EmployeeCap", 5);
        set => PlayerPrefs.SetInt("EmployeeCap", value);
    }
}