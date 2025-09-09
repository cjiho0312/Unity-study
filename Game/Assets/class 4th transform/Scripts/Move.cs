using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Vector3 direction;
    [SerializeField] float speed = 30.0f;

    public void OnMove(Vector3 vector3)
    {
        direction = vector3;

        // 백터의 크기를 1로 설정합니다.
        direction.Normalize();

        // Time.deltaTime
        // 마지막 프레임 이후의 완료되는 시간
        transform.position = transform.position + direction * Time.deltaTime * speed;
    }
}
