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

        void Awake()
        {
            CheckRequirement();
        }

        void Start()
        {
            this.unitLevel.experience.employeeType = this.unitLevel.employeeType;
        }

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
            CheckRequirement();
        }

        void CheckRequirement()
        {
            if (this.unitLevel.RequirementMet())
            {
                this.transform.parent = FindObjectOfType<CompletedAchievement>().transform;
                FindObjectOfType<VerticalLayoutGroupHeight>().UpdateScrollRectHeight();
            }
        }

        void UpdateUI()
        {
            this.achievementImage.fillAmount = this.unitLevel.experience.CurrentLevel / this.unitLevel.requirement;
            this.achievementText.text = $"{this.unitLevel.name}: {Mathf.Clamp(this.unitLevel.experience.CurrentLevel, 0, this.unitLevel.requirement)}/{this.unitLevel.requirement}";
        }
    }
}