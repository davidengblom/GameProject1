using UnityEngine;

[CreateAssetMenu]
public class Resource : ScriptableObject
{
    public Color color;
    public int amountPerClick = 1;

    public int Owned {
        get => PlayerPrefs.GetInt(this.name, 0);
        set => PlayerPrefs.SetInt(this.name, value);
    }

    public void Produce()
    {
        this.Owned += this.amountPerClick;
    }
}


