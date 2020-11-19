using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistantObjects : MonoBehaviour
{
    public GameObject[] persistantObjects;

    static bool _hasBeenInstaniated = false;

    void Start()
    {
        if (_hasBeenInstaniated) return;

        for (var i = 0; i < this.persistantObjects.Length; i++)
        {
            var obj = Instantiate(this.persistantObjects[i], this.transform.parent);
            DontDestroyOnLoad(obj);
        }

        _hasBeenInstaniated = true;
    }
}