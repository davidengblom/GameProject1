using System;
using Achievements;
using HUD;
using UnityEngine;

public class CharacterLevel : MonoBehaviour
{
    
    private void Update()
    {
        CalculateTotalLevel();
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
