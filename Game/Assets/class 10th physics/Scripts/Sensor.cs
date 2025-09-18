using UnityEngine;

public class Sensor : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter");
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("Trigger Stay");

        Jump();
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger Exit");
    }
}
