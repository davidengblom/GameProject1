using UnityEngine;
using UnityEngine.UI;

public class ResourceUI : MonoBehaviour {
    public Text amountText;
    public Resource resource;
    void Update()
    {
        amountText.text = resource.Owned.ToString();   
    }
}

