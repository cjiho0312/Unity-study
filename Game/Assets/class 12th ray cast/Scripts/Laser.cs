using Unity.VisualScripting;
using UnityEngine;

public class Laser : MonoBehaviour
{
    [SerializeField] Ray ray;
    [SerializeField] float maxDistance = 100.0f;
    [SerializeField] RaycastHit rayCastHit;
    [SerializeField] LayerMask layerMask;
    [SerializeField] float Strength = 1.0f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Debug.DrawRay(ray.origin, ray.direction * maxDistance, Color.red);

            if(Physics.Raycast(ray, out rayCastHit, maxDistance, layerMask))
            {
                Debug.Log(rayCastHit.collider.name);

                rayCastHit.collider.GetComponent<HealthBar>().GetHurt(Strength);
            }
        }
    }
}
