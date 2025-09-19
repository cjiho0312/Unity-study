using UnityEngine;

public class Control : MonoBehaviour
{
    [SerializeField] float power;
    [SerializeField] float fixedPower;
    [SerializeField] Vector3 direction;
    [SerializeField] Vector3 originPosition;
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] ForceMode forceMode;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        forceMode = ForceMode.Force;
        originPosition = transform.position;
        fixedPower = power;
    }

    void Update()
    {
        // 입력 받는 코드는 Update에서

        if (Input.GetKeyDown(KeyCode.Space))
        {
            ResetBall();
        }

        direction.x = Input.GetAxisRaw("Horizontal");
        direction.z = Input.GetAxisRaw("Vertical");

        direction.Normalize();
    }

    void FixedUpdate()
    {
        // 물리적 연산 (물리 등)은 FixedUpdate에서

        rigidbody.AddForce(direction * power, forceMode);
    }

    public void ResetBall()
    {
        Revert();
        transform.position = originPosition;
    }

    public void Soar()
    {
        power = 1;
        direction = Vector3.up;
        forceMode = ForceMode.Impulse;
    }

    public void Revert()
    {
        power= fixedPower;
        direction = Vector3.zero;
        forceMode = ForceMode.Force;
    }
}
