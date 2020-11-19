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
    private float resetTimer;

    private void Start()
    {
        StartCoroutine(Timer());
    }

    private IEnumerator Timer()
    {
        timer = countDownTime;

        do
        {
            timer -= Time.deltaTime;

            FormatText();

            yield return null;

        } while (timer > 0);
    }

    void FormatText()
    {
        int day = (int) (timer / 86400) % 365;
        int hour = (int)(timer / 3600) % 24;
        int minute = (int)(timer / 60) % 60;
        int second = (int) (timer % 60);
        
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
