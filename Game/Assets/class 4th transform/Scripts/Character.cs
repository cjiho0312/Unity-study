using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    public float speed = 30.0f;
    void Start()
    {
        Debug.Log(transform.position);
    }

    void Update()
    {
        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        // ������ ũ�⸦ 1�� �����մϴ�.
        direction.Normalize();

        // Time.deltaTime
        // ������ ������ ������ �Ϸ�Ǵ� �ð�
        transform.position = transform.position + direction * Time.deltaTime * speed;

        // if (Input.GetKey(KeyCode.W))
        // {
        //     transform.position += Vector3.forward;
        // }
        // if (Input.GetKey(KeyCode.A))
        // {
        //     transform.position += Vector3.left;
        // }
        // if (Input.GetKey(KeyCode.S))
        // {
        //     transform.position += Vector3.back;
        // }
        // if (Input.GetKey(KeyCode.D))
        // {
        //     transform.position += Vector3.right;
        // }

    }
}
