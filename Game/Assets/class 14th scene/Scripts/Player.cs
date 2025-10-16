using UnityEngine;

public class Player : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
        {
            Debug.Log("W");
            transform.position += new Vector3(0.05f, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("S");
            transform.position -= new Vector3(0.05f, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("A");
            transform.position += new Vector3(0, 0, 0.05f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("D");
            transform.position -= new Vector3(0, 0, 0.05f);
        }
    }
}
