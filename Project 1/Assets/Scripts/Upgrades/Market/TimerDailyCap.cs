using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDailyCap : MonoBehaviour
{
    public Market dailyCap;
    public Text timerText;
    public float countDownTime = 24;

    private float timer;

    private void Update()
    {
        
    }

    void FormatText()
    {
        int hour = (int)(timer / 3600) % 24;
        int minute = (int)(timer / 60) % 60;
        int second = (int) (timer / 60);

        if (hour > 0) { timerText.text += $"{hour}:"; }
        if (minute > 0) { timerText.text += minute; }
        if (second > 0) { timerText.text += second; }
    }
    
    public float SaveTime
    {
        get => PlayerPrefs.GetFloat("Timer", 0);
        set => PlayerPrefs.SetFloat("Timer", Mathf.Clamp(value, 0,countDownTime));
    }
}
