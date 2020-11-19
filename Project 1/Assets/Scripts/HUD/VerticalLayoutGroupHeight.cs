using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalLayoutGroupHeight : MonoBehaviour
{
    void Start()
    {
        UpdateScrollRectHeight();
    }

    public void UpdateScrollRectHeight()
    {
        var childCount = 0;
        var height = 0f;
        childCount = this.transform.childCount;
        if (childCount == 0) return;
        var child = this.transform.GetChild(0);
        height = child.GetComponent<RectTransform>().rect.height;

        var rect = GetComponent<RectTransform>();
        rect.sizeDelta = new Vector2(rect.sizeDelta.x, height * childCount);
    }
}