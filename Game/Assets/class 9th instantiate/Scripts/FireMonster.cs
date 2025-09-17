using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class FireMonster : MonoBehaviour
{
    float startX, startZ;
    bool goUp = true;

    void Start()
    {
        startX = Random.Range(-2.0f, 2.0f);
        startZ = Random.Range(-2.0f, 2.0f);

        transform.position = new Vector3(startX, 0, startZ);
    }

    private void Update()
    {
        if (transform.position.y <= 0)
        {
            goUp = true;
        }
        else if (transform.position.y >= 0.6f)
        {
            goUp = false;
        }

        if (goUp)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 0.001f, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 0.001f, transform.position.z);
        }

    }

}
