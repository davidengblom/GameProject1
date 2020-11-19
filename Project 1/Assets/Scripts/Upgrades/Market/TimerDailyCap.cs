using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerDailyCap : MonoBehaviour
{
    public Market dailyCap;
    public Text timerText;
    public float setDays = 1;
    public float setHours = 1;

    private float timer;
    private float resetTimer;

    private void Start()
    {
        
    }

    private void Update()
    {
        FormatText();
    }

    void FormatText()
    {
        int day = (int) (timer / 86400) % 365;
        int hour = (int)(day / 3600) % 24;
        int minute = (int)(hour/ 60) % 60;
        int second = (int) (minute % 60);
        
        if (day > 0) { timerText.text += $"{day}d "; }
        if (hour > 0) { timerText.text += $"{hour}h "; }
        if (minute > 0) { timerText.text += $"{minute}m "; }
        if (second > 0) { timerText.text += $"{second}s "; }
    }
    
    public float SaveTime
    {
        get => PlayerPrefs.GetFloat("Timer", 0);
        set => PlayerPrefs.SetFloat("Timer", Mathf.Clamp(value, 0,countDownTime));
    }
}
