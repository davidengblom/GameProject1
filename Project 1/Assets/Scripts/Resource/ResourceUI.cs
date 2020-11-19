using System;
using UnityEngine;
using UnityEngine.UI;

public class ResourceUI : MonoBehaviour, IReset
{
    public Text amountText;
    public Resource resource;

    void Update()
    {
        amountText.text = resource.Owned.ToString();
    }

    public void Reset()
    {
        this.resource.Owned = 0;
    }
}