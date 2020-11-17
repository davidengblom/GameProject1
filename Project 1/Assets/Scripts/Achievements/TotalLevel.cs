using HUD;
using UnityEngine;
using Upgrades.Character;

namespace Achievements
{
    [CreateAssetMenu(fileName = "New Level Achievement", menuName = "New Achievement/Total Level Achievement")]
    public class TotalLevel : ScriptableObject
    {
        public Resource resourceReward;
        public int requirement;
        public int reward = 0;

        public bool RequirementMet()
        {
            var totalLevel = 0;

            foreach (var level in FindObjectsOfType<ExperienceUI>())
            {
                totalLevel += level._experience.CurrentLevel;
            }
            return totalLevel >= this.requirement;
        }

        public int HasBeenRewarded
        {
            get => PlayerPrefs.GetInt(this.name, 0);
            set => PlayerPrefs.SetInt(this.name, value);
        }
    }
}