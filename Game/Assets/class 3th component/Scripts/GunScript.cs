using UnityEngine;

public class GunScript : MonoBehaviour
{
    [SerializeField] private Transform gunTransform;

    private void Awake()
    {
        gunTransform = GetComponent<Transform>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
