using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HoverOverDescription : MonoBehaviour, IEventSystemHandler
{
    public GameObject description;

    void Update()
    {
        var pointer = new PointerEventData(EventSystem.current) {position = Input.mousePosition};

        var rayCastResult = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointer, rayCastResult);

        if (rayCastResult.Count > 0)
        {
            foreach (var result in rayCastResult)
            {
                if (result.gameObject.name == this.gameObject.name)
                {
                    this.description.SetActive(true);
                    return;
                }
            }
        }

        this.description.SetActive(false);
    }
}