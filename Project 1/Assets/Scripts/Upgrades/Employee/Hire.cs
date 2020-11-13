using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using UnityEngine;

public class Hire : MonoBehaviour
{
    const string lumberJack = "lumberJack";
    const string miner = "miner";
    const string hunter = "hunter";

    public int LumberJack
    {
        get => PlayerPrefs.GetInt("lumberJack", 0);
        set => PlayerPrefs.SetInt("lumberJack", value);
    }

    public int Miner
    {
        get => PlayerPrefs.GetInt("miner", 0);
        set => PlayerPrefs.SetInt("miner", value);
    }

    public int Hunter
    {
        get => PlayerPrefs.GetInt("hunter", 0);
        set => PlayerPrefs.SetInt("hunter", value);
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
