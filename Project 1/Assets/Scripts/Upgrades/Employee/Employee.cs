using UnityEngine;
using UnityEngine.UI;

public class Employee : MonoBehaviour
{
    public int productionAmount = 1;
    public float productionTime = 1f;

    public Text resourceAmountText;
    public Text resourceTypeText;
    public Resource resource;
    

    float elapsedTime;

    private void Start()
    {
        UpdateResourceAmountLabel();
        this.resourceTypeText.text = this.resource.name;
    }

    void Update()
    {
        this.elapsedTime += Time.deltaTime;
        if (this.elapsedTime >= this.productionTime)
        {
            ProduceResource();
            this.elapsedTime -= this.productionTime;
        }
        UpdateResourceAmountLabel();
    }

    void ProduceResource()
    {
        resource.Owned += this.productionAmount;
    }

    void UpdateResourceAmountLabel()
    {
        this.resourceAmountText.text = this.resource.Owned.ToString();
    }

}
