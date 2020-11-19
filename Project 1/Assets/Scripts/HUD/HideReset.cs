using UnityEngine;

public class HideReset : MonoBehaviour
{
  
    CanvasGroup _canvasGroup;

    void Start()
    {
       
        this._canvasGroup = GetComponent<CanvasGroup>();
    }

    void Update()
    {
       
   
    }

    public void ShowResetMenu()
    {
        ShouldHideMenu(false);
    }

    public void HideResetMenu()
    {
        ShouldHideMenu(true);
    }

    void ShouldHideMenu(bool shouldHide)
    {
        if (shouldHide)
        {
            this._canvasGroup.alpha = 0;
            this._canvasGroup.interactable = false;
            this._canvasGroup.blocksRaycasts = false;
        }
        else
        {
            this._canvasGroup.alpha = 1;
            this._canvasGroup.interactable = true;
            this._canvasGroup.blocksRaycasts = true;
        }
    }
}

