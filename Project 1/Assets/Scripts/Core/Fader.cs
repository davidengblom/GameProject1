using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Core
{
    public class Fader : MonoBehaviour
    {
        CanvasGroup _canvasGroup;

        void Start()
        {
            this._canvasGroup = GetComponent<CanvasGroup>();
        }


        public IEnumerator FadeOut()
        {
            this._canvasGroup = GetComponent<CanvasGroup>();
            ActivateCanvasGroup(true);
            var timer = 0f;

            while (timer < 1)
            {
                timer += Time.deltaTime;
                this._canvasGroup.alpha += Time.deltaTime;
                yield return null;
            }
        }

        public IEnumerator FadeIn()
        {
            this._canvasGroup = GetComponent<CanvasGroup>();
            var timer = 1f;

            while (timer > 0)
            {
                print(timer + "   " + this._canvasGroup.alpha);
                timer -= Time.deltaTime;
                this._canvasGroup.alpha -= Time.deltaTime;
                yield return null;
            }

            ActivateCanvasGroup(false);
        }

        void ActivateCanvasGroup(bool shouldShow)
        {
            if (shouldShow)
            {
                this._canvasGroup.interactable = true;
                this._canvasGroup.blocksRaycasts = true;
            }
            else
            {
                this._canvasGroup.interactable = false;
                this._canvasGroup.blocksRaycasts = false;
            }
        }
    }
}