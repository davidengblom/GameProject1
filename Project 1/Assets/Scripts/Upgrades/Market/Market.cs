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

    public float costMultiplier = 2;
    public float goldCostMultiplier = 20;
    public float crystalCostMultiplier = 2;
    public int maxCrystalPerDay = 20;
    
    private string userInput;
    private float amount;
    private string costAmountToText;
    private float costAmount = 0;
    private float crystalCostAmount = 1;
    private float crystalCostAmountDisplayed = 1;

    public Text resourceToBuyTitleText;
    public InputField inputField;
    public Text costAmountText;
    public Text costResourceType;
    public Text crystalButtonText;
    public Text dailyCapText;

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

    void CalcCost(float i)
    {
        costAmount = i * costMultiplier;   
    }

    void CalcGoldCost(float i)
    {
        costAmount = i * goldCostMultiplier;
    }

    void CalcCrystalCost(float i)
    {
        if (CurrentDailyCap < 1) 
        {
            crystalCostAmount = Mathf.Pow(i , crystalCostMultiplier);
            crystalCostAmountDisplayed = Mathf.Pow(i + 1 , crystalCostMultiplier);
        }
        else
        {
            crystalCostAmount = Mathf.Pow(CurrentDailyCap * 1, crystalCostMultiplier);
            crystalCostAmountDisplayed = Mathf.Pow((1 + CurrentDailyCap) * 1 , crystalCostMultiplier);
        }
    }

    void UpdateText()
    {
        costAmountToText = costAmount.ToString();
        resourceToBuyTitleText.text = this.resource.name;
        costResourceType.text = resourceCost1.name;
        costAmountText.text = costAmountToText;
        crystalButtonText.text = $"Buy 1 {crystal.name} for {crystalCostAmountDisplayed} {resourceCost1.name}";
        dailyCapText.text = $"Daily cap: {CurrentDailyCap}/{maxCrystalPerDay}";
    }    

    public void GetInput(string input)
    {
        if (resource.name == gold.name) {
            inputField.text = input;
            userInput = input;
            CalcGoldCost(amount = Convert.ToSingle(userInput));
        } else {
            inputField.text = input;
            userInput = input;
            CalcCost(amount = Convert.ToSingle(userInput));
        }
    }

    public void BuyCrystal()
    {
        if (!CanAffordCrystal()) { return; }
        if (CurrentDailyCap >= maxCrystalPerDay) { return; }
        
        CurrentDailyCap++;
        amount++;
        CalcCrystalCost(amount);
        crystal.Owned++;
        resourceCost1.Owned -= Convert.ToInt32(crystalCostAmount);
    }
    public void ConfirmPurchase()
    {
        if (!CanAfford()) return;
        this.resource.Owned += Convert.ToInt32(amount);
        this.resourceCost1.Owned -= Convert.ToInt32(costAmount);
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
            resourceCost1 = stone;
            resourceCost2 = food;
        }else if (this.resource.name == gold.name) {
            resourceCost1 = food;
            resourceCost2 = wood;
        }else if (this.resource.name == crystal.name) {
            resourceCost1 = gold;
        }
    }

    bool CanAffordCrystal() {
        if (resourceCost1.Owned >= crystalCostAmount) { return true; } return false;
    }
    bool CanAfford() {
        if (resourceCost1.Owned >= costAmount) { return true; } return false;  
    }
    
    public float CurrentDailyCap
    {
        get => PlayerPrefs.GetFloat("DailyCap", 0);
        set => PlayerPrefs.SetFloat("DailyCap", Mathf.Clamp(value, 0, maxCrystalPerDay));
    }
}
