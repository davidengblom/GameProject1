using System;
using UnityEngine;
using UnityEngine.UI;
using Upgrades.Character;

namespace HUD
{
    public class ExperienceUI : MonoBehaviour
    {
        [SerializeField] Image expImage;
        [SerializeField] Text expText;

        Experience _experience;

        void Start()
        {
            this._experience = FindObjectOfType<Experience>();
        }

        void Update()
        {
            UpdateExpImage();
        }

        void UpdateExpImage()
        {
            this.expImage.fillAmount = this._experience.ExperiencePoints / this._experience.ExperienceToNextLevel();
        }
    }
}