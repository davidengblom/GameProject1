using UnityEngine;

public class HideMainMenu : MonoBehaviour
{
    ToggleOptions _toggleOptions;

    CanvasGroup _canvasGroup;

    void Start()
    {
        this._toggleOptions = FindObjectOfType<ToggleOptions>();
        this._canvasGroup = GetComponent<CanvasGroup>();
    }

    void Update()
    {
        if (this._toggleOptions.optionsMenuShowing)
        {
            ShouldHideMenu(true);
        }
        else
        {
            ShouldHideMenu(false);
        }
    }

    public void ShouldHideMenu(bool shouldHide)
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