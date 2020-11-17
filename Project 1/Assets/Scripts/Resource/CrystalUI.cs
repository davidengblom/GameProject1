using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrystalUI : MonoBehaviour
{
    public Resource crystal;
    public Text crystalAmountText;
    
    void Update()
    {
        crystalAmountText.text = $"Crystal: {crystal.Owned}";
    }
}
