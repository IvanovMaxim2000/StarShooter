using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused { get; set; }
    public Timer timer;
    public GameObject PauseMenuUI;

    [SerializeField] PlayerController player;
    [SerializeField] Slider sensivitySlider;


    private void Start()
    {
        GamePaused = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!GamePaused) Break();
            else Continue();
        }
    }

    public void Continue()
    {
        GamePaused = false;
        PauseMenuUI.SetActive(false);
    }

    public void Restart()
    {
        GamePaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Break()
    {
        PauseMenuUI.SetActive(true);
        GamePaused = true;
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void SetSensivity(float value)
    {
        sensivitySlider.value = value;
        player.mouseSense = value;
    }
}
