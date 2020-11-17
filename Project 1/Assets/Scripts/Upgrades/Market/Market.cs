using System;
using UnityEngine;
using UnityEngine.UI;


public class Market : MonoBehaviour
{
    public Resource food;
    public Resource stone;
    public Resource wood;
    public Resource gold;
    
    Resource resource;
    Resource resourceCost1;
    Resource resourceCost2;
    

    private string userInput;
    private int amount;

    public int costMultiplier = 2;
    public int goldCostMultiplier = 20;
    private int costAmount = 0;
    private string costAmountToText = "0";

    public Text resourceToBuyTitleText;
    public InputField inputField;
    public Text enterAmountText;
    public Text costAmountText;
    public Text costResourceType;

    private void Start()
    {
        inputField.text = "0";
    }

    private void Update()
    {
        UpdateText();
    }

    void CalcCost()
    {
        costAmount = amount * costMultiplier;   
    }

    void CalcGoldCost()
    {
        costAmount = amount * goldCostMultiplier;
    }

    void UpdateText()
    {
        costAmountToText = costAmount.ToString();
        resourceToBuyTitleText.text = this.resource.name;
        costResourceType.text = resourceCost1.name;
        costAmountText.text = costAmountToText;
    }

    public void GetInput(string input)
    {
        if (resource.name == "Gold")
        {
            inputField.text = input;
            userInput = input;
            amount = Int32.Parse(userInput);
            CalcGoldCost();
        }
        else
        {
            inputField.text = input;
            userInput = input;
            amount = Int32.Parse(userInput);
            CalcCost();
        }
    }

    public void ConfirmPurchase()
    {
        if (!CanAfford()) return;
        this.resource.Owned += amount;
        this.resourceCost1.Owned -= costAmount;
    }

    public void ResetAmountText()
    {
        costAmount = 0;
        inputField.text = "0";
    }

    public void ChooseResource(Resource chooseResource)
    {
        resource = chooseResource;

        if (this.resource.name == food.name) {
            resourceCost1 = stone;
            resourceCost2 = wood;
        }else if (this.resource.name == stone.name) {
            resourceCost1 = food;
            resourceCost2 = wood;
        }else if (this.resource.name == wood.name) {
            resourceCost1 = food;
            resourceCost2 = stone;
        }else if (this.resource.name == gold.name) {
            resourceCost1 = food;
            resourceCost2 = wood;
        }
    }

    bool CanAfford()
    {
        if (resourceCost1.Owned >= costAmount) {
            return true;
        }
        return false;  
    }
}
