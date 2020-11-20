using UnityEngine;
using UnityEngine.UI;

public class TimerDailyCap : MonoBehaviour
{
    public Market dailyCap;
    public Text timerText;
    public Button butCrystalButton;
    public int setHours = 2;
    public int setMinute = 2;
    public float setSeconds = 2;
    
    private float time;
    
    private void Start()
    {
        timerText = GetComponent<Text>();
        setHours = setHours * 3600;
        setMinute = setMinute * 60;
        time = setHours + setMinute + setSeconds;
        time = SaveTime;
    }

    private void Update()
    {
        if (dailyCap.DailyCapIsCaped())
        {
            time -= Time.deltaTime;
            SaveTime = time;
            var hours = (((int) SaveTime / 3600) % 24).ToString();
            var minutes = (((int) SaveTime / 60) % 60).ToString();
            var seconds = (SaveTime % 60).ToString("0");

            timerText.text = $"{hours}h {minutes}m {seconds}s";
            if (time >= 0) {
                butCrystalButton.enabled = false;
                dailyCap.CrystalCostAmountDisplayed = 1;
            }else {
                dailyCap.DailyCrystalCount = 0;
                butCrystalButton.enabled = true;
            }
        }
        else {
            time = setHours + setMinute + setSeconds;
            timerText.text = "";
        }
    }

    public float SaveTime
    {
        get => PlayerPrefs.GetFloat("Timer", 0);
        set => PlayerPrefs.SetFloat("Timer", Mathf.Clamp(value, 0,86400));
    }
}
