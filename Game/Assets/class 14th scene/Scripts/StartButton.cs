using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    GameObject sceneryManagerObject;
    Button startButton;

    private void Awake()
    {
        sceneryManagerObject = GameObject.Find("SceneryManager");
        startButton = GetComponent<Button>();
        startButton.onClick.AddListener(PressGameButton);
    }

    public void PressGameButton()
    {
        sceneryManagerObject.GetComponent<SceneryManager>().SceneMove(1);
    }
}
