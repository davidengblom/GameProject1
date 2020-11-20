using System;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

namespace Core
{
    public class SceneLoader : MonoBehaviour
    {
        public void LoadScene(string sceneToLoad)
        {
            DontDestroyOnLoad(this.gameObject);
            StartCoroutine(StartFade(sceneToLoad));
        }

        IEnumerator StartFade(string sceneToLoad)
        {
            DontDestroyOnLoad(this.gameObject);
            yield return FindObjectOfType<Fader>().FadeOut();
            yield return SceneManager.LoadSceneAsync(sceneToLoad);
            //yield return FindObjectOfType<Fader>().FadeIn();
            Destroy(this.gameObject);
        }
    }
}