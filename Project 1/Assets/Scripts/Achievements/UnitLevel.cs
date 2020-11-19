using System;
using UnityEngine;
using Upgrades.Character;

namespace Achievements
{
    [CreateAssetMenu(fileName = "New Unit Achievement", menuName = "New Achievement/Unit Level Achievement")]
    public class UnitLevel : ScriptableObject
    {
        public float requirement;
        public int reward = 0;
        public Resource resourceReward;
        public EmployeeType employeeType;

        [NonSerialized]
        public Experience experience = new Experience();

        public bool RequirementMet()
        {
            return this.experience.employeeType == this.employeeType && this.experience.CurrentLevel >= this.requirement;
        }

        public int HasBeenRewarded
        {
            get => PlayerPrefs.GetInt(this.name, 0);
            set => PlayerPrefs.SetInt(this.name, value);
        }
    }
}