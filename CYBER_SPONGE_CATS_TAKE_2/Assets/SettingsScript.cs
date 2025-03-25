using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsScript : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    public void OnToggleButton()
    {
        Screen.fullScreen = !Screen.fullScreen;
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
    }


    public void OnBackButton()
    {
        SceneManager.LoadScene(0);
    }
}
