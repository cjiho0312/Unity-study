using UnityEngine;

public class Itemmanager : MonoBehaviour
{
    [SerializeField] GameObject[] gameObjects; 
    int gameObjectCount = 0;

    void Start()
    {
        for (int i = 0; i < gameObjects.Length; i++)
        {
            gameObjects[i].SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (gameObjectCount >= gameObjects.Length - 1)
            {
                gameObjectCount = 0;
            }
            if (gameObject[gameObjectCount - 1])
            {

            }

            gameObjects[gameObjectCount++].SetActive(true);


            
        }
    }
}
