using UnityEngine;

namespace Achievements
{
    [CreateAssetMenu]
    public class Achievement : ScriptableObject
    {
        public int reward = 0;
        public Resource resourceReward;
        public AchievementRequirementType achievementRequirementType;
    }

    public enum AchievementRequirementType
    {
        Clicking,
        AutoClicking,
        
    }
}
