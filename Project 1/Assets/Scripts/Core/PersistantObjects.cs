using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantObjects : MonoBehaviour
{
    PersistantObjects instance;

    void Start()
    {
        this.instance = FindObjectOfType<PersistantObjects>();

        DontDestroyOnLoad(this.instance.gameObject);
    }
}