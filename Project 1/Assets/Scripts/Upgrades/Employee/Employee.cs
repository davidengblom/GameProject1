using System;
using UnityEngine;
using Upgrades.Character;

[Serializable]
public class Employee
{
    public EmployeeType type;
    public float productionTime;
    public float timer;

    public bool ShouldProduce => Time.time - this.timer > this.productionTime;

    public int EmployeeLevel
    {
        get => PlayerPrefs.GetInt("EmployeeLevel" + this.type, 1);
        set => PlayerPrefs.SetInt("EmployeeLevel" + this.type, value);
    }

    public void AutoProduce(Resource resource)
    {
        if (!this.ShouldProduce) return;
        this.timer = Time.time;
        resource.Owned += resource.amountPerClick * this.EmployeeLevel;
    }
}