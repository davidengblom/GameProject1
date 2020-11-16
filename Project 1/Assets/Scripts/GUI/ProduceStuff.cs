using UnityEngine;
using UnityEngine.EventSystems;

/// <summary>
/// temporary class to test things out
/// </summary>
public class ProduceStuff : MonoBehaviour, IPointerClickHandler
{
    public Resource resource;

    public void OnPointerClick(PointerEventData eventData)
    {
        this.resource.Produce();
        print(this.resource.Owned + " : " + this.resource.name);
    }
}