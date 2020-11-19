using UnityEngine;
using Upgrades.Character;

[CreateAssetMenu]
public class Resource : ScriptableObject
{
    public Color color;
    public int amountPerClick = 1;
    public int expGainPerClick = 2;
    public Experience _experience;

    public int ClickLevel
    {
        get => PlayerPrefs.GetInt("ClickLevel" + this.name, this.amountPerClick);
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
        this._experience.GainExperience(this.expGainPerClick, this._experience.employeeType);

        foreach (var floatingText in FindObjectsOfType<FloatingText>())
        {
            if (floatingText.resourceName == this.name)
            {
                floatingText.SpawnGoldText(this.amountPerClick * this.ClickLevel);
                break;
            }
        }
    }
}