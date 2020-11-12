using UnityEngine;
using UnityEngine.UI;

public class ResourceUI : MonoBehaviour {
    public Text amountText;
    public Text resourceNameText;
    public Resource resource;
    
    void Start()
    {
        resourceNameText.text = resource.name;
    }
    
    void Update()
    {
        amountText.text = resource.Owned.ToString();   
    }
}

