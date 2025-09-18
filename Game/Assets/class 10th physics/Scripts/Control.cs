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
        // 입력 받는 코드는 Update에서

        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();
    }

    void FixedUpdate()
    {
        // 물리적 연산 (물리 등)은 FixedUpdate에서

        rigidbody.AddForce(direction * speed, ForceMode.Force);
    }

    public void Jump()
    {
        rigidbody.AddForce (new Vector3 (direction.x, direction.y + 0.1f, direction.z), ForceMode.Force);
    }

}
