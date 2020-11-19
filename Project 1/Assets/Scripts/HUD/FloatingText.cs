using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FloatingText : MonoBehaviour
{
    public string resourceName;
    public float speed;
    public float duration = 2f;
    public Text _goldText;
    public string displayText;
    readonly Vector3 _moveDirection = Vector3.up;
    float _resetDuration;

    void Start()
    {
        this.GetComponent<Text>();
        this._resetDuration = this.duration;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SpawnGoldText(1000);
        }
    }

    public void SpawnGoldText(float goldValue)
    {
        this.duration = this._resetDuration;
        var instance = Instantiate(this._goldText, this.transform);
        instance.transform.position = this.transform.position;
        instance.text = $"+{goldValue.ToString()} {this.displayText}";
        this.StartCoroutine(this.GoldTextAnimation(instance));
    }

    IEnumerator GoldTextAnimation(Text text)
    {
        var canvasGroup = text.GetComponent<CanvasGroup>();
        while (this.duration > 0)
        {
            this.duration -= Time.deltaTime;
            canvasGroup.alpha -= (Time.deltaTime / this._resetDuration);
            text.transform.position += this._moveDirection * this.speed * Time.deltaTime;
            yield return null;
        }

        Destroy(text.gameObject);
    }
}