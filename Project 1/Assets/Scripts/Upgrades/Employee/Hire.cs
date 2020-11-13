using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using UnityEngine;

public class Hire : MonoBehaviour
{

    public int LumberJack
    {
        get => PlayerPrefs.GetInt(this.name, 0);
        set => PlayerPrefs.SetInt(this.name, value);
    }

    public int Miner
    {
        get => PlayerPrefs.GetInt(this.name, 0);
        set => PlayerPrefs.SetInt(this.name, value);
    }

    public int Hunter
    {
        get => PlayerPrefs.GetInt(this.name, 0);
        set => PlayerPrefs.SetInt(this.name, value);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            LumberJack++;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            print(LumberJack);
        }
    }

}
