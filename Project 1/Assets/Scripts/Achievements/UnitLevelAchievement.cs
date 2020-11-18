using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Achievements
{
    public class UnitLevelAchievement : MonoBehaviour, IPointerClickHandler
    {
        public UnitLevel unitLevel;
        public Image achievementImage;
        public Text achievementText;

        void CanClaimReward()
        {
            print(this.unitLevel.name);
            if (!this.unitLevel.RequirementMet() || this.unitLevel.HasBeenRewarded == 1) return;

            this.unitLevel.resourceReward.Owned += this.unitLevel.reward;
            this.unitLevel.HasBeenRewarded = 1;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            CanClaimReward();
        }

        void Update()
        {
            UpdateUI();
            if (this.unitLevel.RequirementMet())
            {
                this.transform.parent = FindObjectOfType<CompletedAchievement>().transform;
            }
        }

        void UpdateUI()
        {
            print(this.unitLevel.employeeType);
            if (this.unitLevel.experience.employeeType == this.unitLevel.employeeType)
            {
                this.achievementImage.fillAmount = Mathf.RoundToInt(this.unitLevel.experience.CurrentLevel / this.unitLevel.requirement);
                this.achievementText.text = $"{Mathf.Clamp(this.unitLevel.experience.CurrentLevel, 0, this.unitLevel.requirement)}/{this.unitLevel.requirement}";
            }
        }
    }
}