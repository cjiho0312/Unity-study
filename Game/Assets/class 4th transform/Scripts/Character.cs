using UnityEngine;

[RequireComponent (typeof(Move))]
public class Character : MonoBehaviour
{
    [SerializeField] Move move;

    void Start()
    {
        move = GetComponent<Move>();
    }

    void Update()
    {
        move.OnMove(new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical")));
    }

}
