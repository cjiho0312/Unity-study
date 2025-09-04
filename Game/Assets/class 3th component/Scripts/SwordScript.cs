using UnityEngine;

public class SwordScript : MonoBehaviour
{
    [SerializeField] MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    void Start()
    {
        meshRenderer.material.color = Color.grey;
    }
}
