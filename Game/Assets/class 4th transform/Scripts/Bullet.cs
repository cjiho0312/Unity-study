using UnityEngine;

public class Bullet : MonoBehaviour
{
    Character character;
    bool isShoot = false;

    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    void Update()
    {
        if (isShoot)
        {
            Shoot();
        }
        else
        {
            transform.position = character.transform.position;
        }
    }

    void Shoot()
    {

    }
}
