using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float speed = 30.0f;

    public void OnMove(Vector3 vector3)
    {
        direction = vector3;

        // ������ ũ�⸦ 1�� �����մϴ�.
        direction.Normalize();

        // Time.deltaTime
        // ������ ������ ������ �Ϸ�Ǵ� �ð�
        transform.position = transform.position + direction * Time.deltaTime * speed;
    }
}
