using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace GUI
{
    public class InfoPanel : MonoBehaviour, IPointerClickHandler
    {
        [SerializeField] Purchasable purchasable;
        //TODO add UI elements which are used on multiple overview panels, such as title 

        protected Action Purchased;

        public void OnPointerClick(PointerEventData eventData)
        {
            if (!this.purchasable.IsAffordable()) return;
            this.Purchased();
            this.purchasable.resource.Owned -= this.purchasable.cost;
            print(this.purchasable.resource.Owned);
        }

        public void Produce()
        {
            this.purchasable.resource.Produce(); //temporary class to try things out.
            print(this.purchasable.resource.Owned);
        }

    }
}