using System;
using UnityEngine;
using UnityEngine.UI;

namespace GUI
{
    public class EmployeeUI : InfoPanel
    {
        //TODO retrieve data how many employees player has
        //TODO retrieve data on level (and current EXP/progress bar?) the player has
        //public OwnedEmployersUI ownedEmployersUI;
        public Text ownedMinersText;
        public Text ownedLumberJacksText;
        public Text ownedHuntersText;
        public int ownedMiners;
        public int ownedLumberJacks;
        public int ownedHunters;
        [SerializeField] Text tempText;
        int shitty = 0;

        void Start()
        {
            this.tempText.text = this.shitty.ToString();
            this.Purchased += OwnedEmployeesUI;
        }

        public void OwnedEmployeesUI()
        {
            this.shitty++;
            this.tempText.text = this.shitty.ToString();
        }
    }
}