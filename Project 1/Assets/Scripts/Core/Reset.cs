using System;
using UnityEngine;

namespace Core
{
    public class Reset : MonoBehaviour
    {
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                ResetStuff();
            }
        }

        void ResetStuff()
        {
            foreach (var monoBehaviour in FindObjectsOfType<MonoBehaviour>())
            {
                
            }
        }
    }
    
}