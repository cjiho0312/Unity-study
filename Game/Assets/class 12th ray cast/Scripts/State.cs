using UnityEngine;

public class State : MonoBehaviour
{
    [SerializeField] Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Damaged()
    {
        animator.SetTrigger ("6");
    }

    public void Dead()
    {
        animator.SetTrigger ("7");
    }

}
