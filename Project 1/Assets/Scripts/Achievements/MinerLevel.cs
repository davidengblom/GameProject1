using UnityEngine;

namespace Achievements
{
    [CreateAssetMenu(fileName = "New Miner Achievement", menuName = "New Achievement/Miner Achievement", order = 1)]
    public class MinerLevel : ScriptableObject
    {
        public int reward = 0;
        public Resource resourceReward;
        public int requirement;
    }
}