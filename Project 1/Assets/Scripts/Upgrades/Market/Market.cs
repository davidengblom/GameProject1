using System;
using UnityEngine;
using UnityEngine.UI;


public class Market : MonoBehaviour
{
    public Resource food;
    public Resource stone;
    public Resource wood;
    public Resource gold;
    public Resource crystal;
    
    Resource resource;
    Resource resourceCost1;
    Resource resourceCost2;
    

    private string userInput;
    private int amount;

    public int costMultiplier = 2;
    public int goldCostMultiplier = 20;
    public int crystalCostMultiplier = 2;
    public int maxCrystalPerDay = 20;
    private int costAmount = 0;
    private int currentAmount = 0;
    private string costAmountToText;

    public Text resourceToBuyTitleText;
    public InputField inputField;
    public Text costAmountText;
    public Text costResourceType;

    private void Start()
    {
        resource = stone;
        resourceCost1 = stone;
        resourceCost2 = stone;
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

    void CalcCrystalCost()
    {
        //TODO crystal cost gold, the first crystal should cost 1 gold, then it should be multiplied by 2 for every crystal you buy.
        // 1 kristall = 2 gold
        // 2 kristall = 4 gold
        // 3 kristall = 8 gold

        costAmount = amount * crystalCostMultiplier;

        //currentAmount += amount;
        /*if (currentAmount <= maxCrystalPerDay) {
            costAmount = amount * crystalCostMultiplier;
            crystalCostMultiplier *= crystalCostMultiplier; 
        }*/

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
        }else if (resource.name == "Crystal")
        {
            inputField.text = input;
            userInput = input;
            amount = Int32.Parse(userInput);
            CalcCrystalCost();
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
        this.resourceCost1 = null;
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
        }else if (this.resource.name == crystal.name) {
            resourceCost1 = gold;
        }
    }

    bool CanAfford()
    {
        if (resourceCost1.Owned >= costAmount) { return true; }
        return false;  
    }
}
