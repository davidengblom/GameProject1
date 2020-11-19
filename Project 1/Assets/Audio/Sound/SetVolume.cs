using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SetVolume : MonoBehaviour
{
    Slider _slider;

    void Start()
    {
        this._slider = GetComponent<Slider>();
        this._slider.value = SetSFXVolume;
        SFXSetter();
    }

    void Update()
    {
        SFXSetter();
    }


    public float SetSFXVolume
    {
        get => PlayerPrefs.GetFloat("SFXVolume", .1f);
        set => PlayerPrefs.SetFloat("SFXVolume", value);
    }


    void SFXSetter()
    {
        foreach (var audioSource in FindObjectOfType<AudioManager>().GetComponentsInChildren<AudioSource>())
        {
            audioSource.volume = SetSFXVolume;
        }
    }
}