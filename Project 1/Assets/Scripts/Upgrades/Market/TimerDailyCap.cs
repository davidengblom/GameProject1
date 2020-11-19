using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDailyCap : MonoBehaviour
{
    public Market dailyCap;
    public Text timerText;
    public float setTime = 2;

    private void Start()
    {
        setTime = 2 * 3600;
    }

    private void Update()
    {
        setTime -= Time.deltaTime;

        var hours = (((int) setTime / 3600) % 24).ToString();
        var minutes = (((int) setTime / 60) % 60).ToString();
        var seconds = (setTime % 60).ToString("0");

        timerText.text = $"{hours}:{minutes}:{seconds}";
    }

    public float SaveTime
    {
        get => PlayerPrefs.GetFloat("Timer", 0);
        set => PlayerPrefs.SetFloat("Timer", Mathf.Clamp(value, 0,199999));
    }
}
