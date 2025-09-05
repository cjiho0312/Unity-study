using UnityEngine;

public class SwordScript : Item
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

    private void Update()
    {

    }

    public override void Activate()
    {
        Debug.Log("Using Sword");
    }
}
