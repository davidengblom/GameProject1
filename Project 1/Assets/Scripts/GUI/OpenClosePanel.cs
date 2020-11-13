using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace GUI
{
    public class OpenClosePanel : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] GameObject overviewPanel;

        void Update()
        {
            this.DisableOverviewPanel();
        }

        void DisableOverviewPanel()
        {
            if (!Input.GetMouseButtonDown(0) || !this.overviewPanel.activeInHierarchy) return;

            var pointer = new PointerEventData(EventSystem.current);
            pointer.position = Input.mousePosition;

            var raycastResults = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointer, raycastResults);

            if (raycastResults.Count > 0)
            {
                if (raycastResults.Any(go => go.gameObject == this.overviewPanel))
                {
                    return;
                }
            }

            this.overviewPanel.SetActive(false);
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            this.overviewPanel.SetActive(true);
        }
    }
}