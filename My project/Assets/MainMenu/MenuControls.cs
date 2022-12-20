using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene(1);
    }
    
    public void ExitPressed()
    {
        Application.Quit();
    }
}
