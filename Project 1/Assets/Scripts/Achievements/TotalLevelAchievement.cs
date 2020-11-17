using UnityEngine;
using UnityEngine.EventSystems;

namespace Achievements
{
    public class TotalLevelAchievement : MonoBehaviour, IPointerClickHandler
    {
        public TotalLevel totalLevel;

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
    }
}