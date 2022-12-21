using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused { get; set; }
    public Timer timer;
    public GameObject pauseMenuUI;

    [SerializeField] PlayerController player;
    [SerializeField] Slider sensivitySlider;


    private void Start()
    {
        gamePaused = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!gamePaused) Break();
            else Continue();
        }
    }

    public void Continue()
    {
        gamePaused = false;
        pauseMenuUI.SetActive(false);
    }

    public void Restart()
    {
        gamePaused = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Break()
    {
        pauseMenuUI.SetActive(true);
        gamePaused = true;
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
