using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void OnSettingsButton()
    {
        SceneManager.LoadScene(2);
    }
    public void OnQuitButton()
    {
        Application.Quit();
    }
}
