using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace HUD
{
    public class ToggleOverviewPanel : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] GameObject overviewPanel;
        CanvasGroup _canvasGroup;
        CanvasGroup[] _canvasGroups;
    
        void Start()
        {
            this._canvasGroups = FindObjectsOfType<CanvasGroup>();
            this._canvasGroup = this.overviewPanel.GetComponent<CanvasGroup>();
            ShouldShowPanel(false);
        }
    
        void Update()
        {
            DisableOverviewPanel();
        }
    
        void DisableOverviewPanel()
        {
            if (!Input.GetMouseButtonDown(0) || !this.overviewPanel.activeInHierarchy) return;
    
            var pointer = new PointerEventData(EventSystem.current) {position = Input.mousePosition};
    
            var raycastResults = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointer, raycastResults);
    
            if (raycastResults.Count > 0)
            {
                if (raycastResults.Count != 1) return;
                foreach (var t in raycastResults.Where(t => 1 << t.gameObject.layer == LayerMask.GetMask("Panel")))
                {
                    ShouldShowPanel(false);
                }
            }
    
            ShouldShowPanel(false);
        }
    
        public void OnPointerClick(PointerEventData eventData)
        {
            ShouldShowPanel(false);
            ShouldShowPanel(true);
        }
    
        void ShouldShowPanel(bool shouldShowPanel)
        {
            foreach (var toggleOverviewPanel in FindObjectsOfType<CanvasGroup>())
            {
                if (shouldShowPanel)
                {
                    this._canvasGroup.alpha = 1;
                    this._canvasGroup.interactable = true;
                    this._canvasGroup.blocksRaycasts = true;
                }
                else
                {
                    toggleOverviewPanel.alpha = 0;
                    toggleOverviewPanel.interactable = false;
                    toggleOverviewPanel.blocksRaycasts = false;
                }
            }
        }
    }
}
