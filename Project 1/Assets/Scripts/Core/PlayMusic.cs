using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayMusic : MonoBehaviour
{
    Slider _slider;
    public AudioSource _audioSource;

    void Start()
    {
        this._slider = GetComponent<Slider>();
        this._slider.value = SetMusicVolume;
        VolumeSetter();
    }

    void Update()
    {
        VolumeSetter();
    }

    public float SetMusicVolume
    {
        get => PlayerPrefs.GetFloat("MusicVolume", .1f);
        set => PlayerPrefs.SetFloat("MusicVolume", value);
    }

    void VolumeSetter()
    {
        this._audioSource.volume = SetMusicVolume;
    }
}