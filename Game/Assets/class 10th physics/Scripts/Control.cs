using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] Vector3 direction;
    [SerializeField] Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // �Է� �޴� �ڵ�� Update����

        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();
    }

    void FixedUpdate()
    {
        // ������ ���� (���� ��)�� FixedUpdate����

        rigidbody.AddForce(direction * speed, ForceMode.Force);
    }

    public void Jump()
    {
        rigidbody.AddForce (new Vector3 (direction.x, direction.y + 0.1f, direction.z), ForceMode.Force);
    }

}
