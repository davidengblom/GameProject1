using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Achievements
{
    public class UnitLevelAchievement : MonoBehaviour, IPointerClickHandler
    {
        public UnitLevel unitLevel;


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
    }
}