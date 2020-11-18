using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldUI : MonoBehaviour, IReset
{
    public Resource gold;
    public Text amountText;

    void Update()
    {
        amountText.text = $"Gold: {gold.Owned}";
    }

    public void Reset()
    {
        this.gold.Owned = 0;
    }
}