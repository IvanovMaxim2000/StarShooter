using TMPro;
using UnityEngine;
using System;

public class Timer : MonoBehaviour
{
    public float time { get; private set; }
    public TextMeshProUGUI timer_label;
    public GameObject endMenu;

    void Start() => time = 30f;
    
    void Update()
    {
        if (time > 0)
        {
            TimeRuns();
            ShowTime(time);
        }
        else
        {
            PauseMenu.GamePaused = true;
            endMenu.SetActive(true);
        }
    }
    public void TimeRuns()
    {
        if (!PauseMenu.GamePaused) time -= Time.deltaTime;
    }

    void ShowTime(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        timer_label.text = $"{minutes}:{seconds}";
    }
}
