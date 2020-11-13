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
        CanvasGroup _canvasGroup;


        void Start()
        {
            this._canvasGroup = this.overviewPanel.GetComponent<CanvasGroup>();
            ShouldShowPanel(false);
        }

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
                return;
                // foreach (var result in raycastResults)
                // {
                //     return;
                // }
            }

            ShouldShowPanel(false);
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            this.ShouldShowPanel(true);
        }

        void ShouldShowPanel(bool shouldShowPanel)
        {
            if (shouldShowPanel)
            {
                this._canvasGroup.alpha = 1;
                this._canvasGroup.interactable = true;
            }
            else
            {
                this._canvasGroup.alpha = 0;
                this._canvasGroup.interactable = false;
            }
        }
    }
}