using System.Security.Cryptography;
using UnityEngine;

public class Smelter : MonoBehaviour
{
    [SerializeField] float progress;
    [SerializeField] int count;

    public void Success()
    {
        Debug.Log("Success");
    }

    public void Process(float progress)
    {
        this.progress += progress;

        Debug.Log(this.progress + "% process");

        if (this.progress >= 100.0f)
        {
            Success();

            this.progress = 0.0f;

            Debug.Log(this.progress + "% process");
        }
    }

    public void Enhance (int count)
    {
        this.count += count;
        
        Debug.Log("count : " + this.count);
    }
}
