using System;
using System.Threading;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject character;

    float bulletDistance;
    bool isShoot;

    void Start()
    {
        transform.position = character.GetComponent<Transform>().position;
        isShoot = false;
        bulletDistance = 0;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isShoot == false)
        {
            isShoot = true;
            bulletDistance = 0;
            transform.position = new Vector3 (transform.position.x - 4, transform.position.y, transform.position.z);
        }

        if (isShoot == true)
        {
            Shoot();
        }
        else if (isShoot == false)
        {
            transform.position = character.GetComponent<Transform>().position;
        }
    }

    void Shoot()
    {
        if (bulletDistance > 100.0f)
        {
            isShoot = false;
            return;
        }

        transform.position += (new Vector3(0,0,0.5f));
        bulletDistance += 0.5f;
    }
}
