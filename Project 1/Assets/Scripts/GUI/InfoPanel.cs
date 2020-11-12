using UnityEngine;
using UnityEngine.EventSystems;

namespace GUI
{
    public class InfoPanel : MonoBehaviour, IPointerClickHandler
    {
        //TODO create a serializable class for resourceCost and resourceType
        //TODO add UI elements which are used on multiple overview panels, such as title 

        public void OnPointerClick(PointerEventData eventData)
        {
            //TODO create a bool that checks whether the player has enough resources to proceed with the purchase 
            //TODO subtract resource on purchase 
        }
        
    }
}