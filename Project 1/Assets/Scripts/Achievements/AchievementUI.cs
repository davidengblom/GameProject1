using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Image = UnityEngine.UIElements.Image;

namespace Achievements
{
    public class AchievementUI : MonoBehaviour
    {
        // public Image achievementImage;
        // public Text achievementText;

        void Update()
        {
            foreach (var component in GetComponents<MonoBehaviour>())
            {
                if (component is IPointerClickHandler clickHandler)
                {
                    print(clickHandler);
                }
            }
        }
    }
}