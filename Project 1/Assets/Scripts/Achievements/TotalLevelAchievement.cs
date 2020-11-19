using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Achievements
{
    public class TotalLevelAchievement : MonoBehaviour, IPointerClickHandler
    {
        public TotalLevel totalLevel;
        public Image achievementImage;
        public Text achievementText;

        void Awake()
        {
            CheckRequirement();
        }

        void ClaimReward()
        {
            print(this.totalLevel.name);
            if (!this.totalLevel.RequirementMet() || this.totalLevel.HasBeenRewarded == 1) return;

            this.totalLevel.resourceReward.Owned += this.totalLevel.reward;
            this.totalLevel.HasBeenRewarded = 1;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            ClaimReward();
        }

        void Update()
        {
            UpdateUI();
            CheckRequirement();
        }

        void CheckRequirement()
        {
            if (this.totalLevel.RequirementMet())
            {
                this.transform.parent = FindObjectOfType<CompletedAchievement>().transform;
                FindObjectOfType<VerticalLayoutGroupHeight>().UpdateScrollRectHeight();
            }
        }

        void UpdateUI()
        {
            this.achievementImage.fillAmount = this.totalLevel.CalculateTotalLevel() / this.totalLevel.requirement;
            this.achievementText.text = $"{Mathf.Clamp(this.totalLevel.CalculateTotalLevel(), 0, this.totalLevel.requirement)}/{this.totalLevel.requirement}";
        }
    }
}