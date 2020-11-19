using System;
using Achievements;
using HUD;
using UnityEngine;
using UnityEngine.UI;

public class CharacterLevel : MonoBehaviour
{
    public Text levelNumberText;
    public Resource resource;
    
    private void Start()
    {
        
    }

    private void Update()
    {
        levelNumberText.text = "Total level: " + CalculateTotalLevel();
        if()
        UpgradeClickAmount();
    }

    public void UpgradeClickAmount()
    {
        resource.ClickLevel += Convert.ToInt32(CalculateTotalLevel());
    }

    public float CalculateTotalLevel()
    {
        var totalLevel = 0;

        foreach (var level in FindObjectsOfType<AchievementReference>())
        {
            totalLevel += level.GetComponent<ExperienceUI>()._experience.CurrentLevel;
        }

        return totalLevel;
    }
}
