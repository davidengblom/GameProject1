using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldUI : MonoBehaviour
{
    public Resource gold;
    public Text amountText;
    void Update()
    {
        amountText.text = $"Gold: {gold.Owned}";
    }
}
