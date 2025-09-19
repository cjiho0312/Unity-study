using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] int score;

    public void plusScore()
    {
        score += 1;

        Debug.Log("Score : " + score);
    }
}
