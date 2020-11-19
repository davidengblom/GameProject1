using System;
using Achievements;
using HUD;
using UnityEngine;

namespace Core
{
    public class Reset : MonoBehaviour
    {
        public Resource _resource;

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                ResetGame();
            }
        }

        void ResetGame()
        {
            this._resource.Owned += (int) (CalculateTotalLevel() * .2f);
            
            foreach (var monoBehaviour in FindObjectsOfType<MonoBehaviour>())
            {
                if (monoBehaviour is IReset res)
                {
                    res.Reset();
                }
            }
        }

        float CalculateTotalLevel()
        {
            var totalLevel = 0f;
            foreach (var reference in FindObjectsOfType<AchievementReference>())
            {
                totalLevel += reference.GetComponent<ExperienceUI>()._experience.CurrentLevel;
            }

            return totalLevel;
        }
    }
}