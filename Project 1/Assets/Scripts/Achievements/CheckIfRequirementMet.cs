using System;
using UnityEngine;

namespace Achievements
{
    public class CheckIfRequirementMet : MonoBehaviour
    {
        public UnitLevel[] unitLevel;


        public void CanClaimReward()
        {
            foreach (var level in this.unitLevel)
            {
                if (!level.RequirementMet() || level.HasBeenRewarded == 1) continue;
            
                level.resourceReward.Owned += level.reward;
                level.HasBeenRewarded = 1;
            }
        }
    }
}