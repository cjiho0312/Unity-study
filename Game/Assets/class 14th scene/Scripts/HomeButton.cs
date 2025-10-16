using UnityEngine;
using UnityEngine.UI;

public class HomeButton : MonoBehaviour
{
    GameObject sceneryManagerObject;
    Button homeButton;

    private void Awake()
    {
        sceneryManagerObject = GameObject.Find("SceneryManager");
        homeButton = GetComponent<Button>();
        homeButton.onClick.AddListener(PressHomeButton);
    }

    public void PressHomeButton()
    {
        sceneryManagerObject.GetComponent<SceneryManager>().SceneMove(0);
    }

}
