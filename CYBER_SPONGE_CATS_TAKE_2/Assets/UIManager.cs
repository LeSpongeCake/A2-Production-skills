using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text titleText;
    [SerializeField] Button pressMeButton;

    void Start()
    {
        pressMeButton.onClick.AddListener(() => {
            titleText.text = "ButtonPressed!";
        });
    }
}
