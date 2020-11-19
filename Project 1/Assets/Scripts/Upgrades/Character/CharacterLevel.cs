using System;
using Achievements;
using HUD;
using UnityEngine;
using UnityEngine.UI;

public class CharacterLevel : MonoBehaviour
{
    public Text levelNumberText;
    
    private void Start()
    {
        
    }

    private void Update()
    {
        levelNumberText.text = "Total level: " + CalculateTotalLevel();
    }

    public int UpgradeAmountPerClick(int i)
    {
        i *= Convert.ToInt32(CalculateTotalLevel());

        return i;
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
