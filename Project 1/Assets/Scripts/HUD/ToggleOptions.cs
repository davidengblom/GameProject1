using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleOptions : MonoBehaviour
{
    public bool optionsMenuShowing = false;


    void Start()
    {
        ShowCanvasGroup(false);
    }

    public void OpenOptionsMenu()
    {
        ShowCanvasGroup(true);
    }


    public void CloseOptionsMenu()
    {
        ShowCanvasGroup(false);
    }

    void ShowCanvasGroup(bool shouldShow)
    {
        var canvasGroup = GetComponent<CanvasGroup>();
        if (shouldShow)
        {
            canvasGroup.alpha = 1;
            canvasGroup.interactable = true;
            canvasGroup.blocksRaycasts = true;
            this.optionsMenuShowing = true;
        }
        else
        {
            canvasGroup.alpha = 0;
            canvasGroup.interactable = false;
            canvasGroup.blocksRaycasts = false;
            this.optionsMenuShowing = false;
        }
    }
}