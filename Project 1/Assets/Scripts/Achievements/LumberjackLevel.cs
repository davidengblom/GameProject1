using UnityEngine;

namespace Achievements
{
    [CreateAssetMenu(fileName = "New Lumberjack Achievement", menuName = "New Achievement/Lumberjack Achievement")]
    public class LumberjackLevel : ScriptableObject
    {
        public int reward = 0;
        public Resource resourceReward;
        public int requirement;
    }
}