using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float time { get; private set; }
    public TextMeshProUGUI timerLabel;
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
            PauseMenu.gamePaused = true;
            endMenu.SetActive(true);
        }
    }
    public void TimeRuns()
    {
        if (!PauseMenu.gamePaused) time -= Time.deltaTime;
    }

    void ShowTime(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        timerLabel.text = $"{minutes}:{seconds}";
    }
}
