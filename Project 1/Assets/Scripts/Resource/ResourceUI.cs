using UnityEngine;
using UnityEngine.UI;

public class ResourceUI : MonoBehaviour {
    public Text amountText;
    public Text resourceNameText;
    public Resource resource;
    
    void Start()
    {
        resourceNameText.text = resource.name;
        amountText.color = resource.color;

    }
    
    void Update()
    {
        amountText.text = resource.Owned.ToString();   
    }
}

