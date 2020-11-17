using UnityEngine;

namespace Achievements
{
    [CreateAssetMenu(fileName = "New Level Achievement", menuName = "New Achievement/Level Achievement")]
    public class TotalLevel : ScriptableObject
    {
        public Resource resourceReward;
        public int requirement;
        public int reward = 0;
    }
}