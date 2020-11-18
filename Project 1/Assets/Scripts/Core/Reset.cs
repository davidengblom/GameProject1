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
                ResetGame();
            }
        }

        void ResetGame()
        {
            foreach (var monoBehaviour in FindObjectsOfType<MonoBehaviour>())
            {
                if (monoBehaviour is IReset res)
                {
                    res.Reset();
                }
            }
        }
    }
}