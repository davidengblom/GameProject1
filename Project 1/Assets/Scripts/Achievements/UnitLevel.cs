using UnityEngine;
using Upgrades.Character;

namespace Achievements
{
    [CreateAssetMenu(fileName = "New Unit Achievement", menuName = "New Achievement/Unit Level Achievement")]
    public class UnitLevel : ScriptableObject
    {
        public int requirement;
        public int reward = 0;
        public Resource resourceReward;
        public EmployeeType employeeType;

        Experience _experience;

        public bool RequirementMet()
        {
            return this._experience.employeeType == this.employeeType && this._experience.CurrentLevel >= this.requirement;
        }

        public int HasBeenRewarded
        {
            get => PlayerPrefs.GetInt(this.name, 0);
            set => PlayerPrefs.SetInt(this.name, value);
        }
    }
}