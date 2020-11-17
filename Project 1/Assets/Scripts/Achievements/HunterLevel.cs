using UnityEngine;

namespace Achievements
{
    [CreateAssetMenu(fileName = "New Hunter Achievement", menuName = "New Achievement/Hunter Achievement")]
    public class HunterLevel : ScriptableObject
    {
        public int requirement;
        public int reward = 0;
        public Resource resourceReward;
    }
}