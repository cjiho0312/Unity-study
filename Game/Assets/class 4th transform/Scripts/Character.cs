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

        // 백터의 크기를 1로 설정합니다.
        direction.Normalize();

        // Time.deltaTime
        // 마지막 프레임 이후의 완료되는 시간
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
