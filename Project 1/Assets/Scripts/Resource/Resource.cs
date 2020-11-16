using UnityEngine;
using Upgrades.Character;

[CreateAssetMenu]
public class Resource : ScriptableObject
{
    public Color color;
    public int amountPerClick = 1;
    public int expGainPerClick = 2;
    public EmployeeType employeeType;

    public int ClickLevel
    {
        get => PlayerPrefs.GetInt("ClickLevel" + this.name, 1);
        set => PlayerPrefs.SetInt("ClickLevel" + this.name, value);
    }
    

    public int Owned
    {
        get => PlayerPrefs.GetInt(this.name, 0);
        set => PlayerPrefs.SetInt(this.name, value);
    }

    public void Produce()
    {
        this.Owned += this.amountPerClick * this.ClickLevel;
        FindObjectOfType<Experience>().GainExperience(this.expGainPerClick, this.employeeType);
    }
}