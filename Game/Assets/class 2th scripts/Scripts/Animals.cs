using UnityEngine;

public class Animals : MonoBehaviour
{
    [SerializeField] Ability ability;

    private void Awake()
    {
        // Awake : ��ü�� ������ �� ȣ��Ǵ� �Լ���, ��ü�� ��Ȱ��ȭ �Ǿ����� ������
        //         ȣ��ǰ�, �� �� ���� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        // Start, OnEnable ���� ����Ǵ� �Լ�. �����͸� �ҷ��� �� ����� �� ����.

        Debug.Log("Awake");

        Debug.Log(ability.Strength);
    }

    private void OnEnable()
    {
        // OnEnable : ��ü�� Ȱ��ȭ �Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        // ��Ȱ��ȭ �ߴٰ� �ٽ� Ȱ��ȭ�� ������ �� ȣ��Ǳ� ������, �̺�Ʈ�� ����� �� �����.

        Debug.Log("OnEnable");
    }

    void Start()
    {
        // Start : ��ü�� �����Ǿ��� �� ȣ��Ǹ�, �� �� ���� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        // FixedUpdate : Time Step�� ������ ���� ���� ������ �������� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("Fixed update");
    }

    void Update()
    {
        // Update : ��ü�� Ȱ��ȭ�Ǵ� ����, �� �����Ӹ��� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // LateUpdate : �� �������� ������ �ܰ迡�� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        // �ȷο� ī�޶� �ý��� � ����� �� ����.

        Debug.Log("Late update");
    }

    private void OnDisable()
    {
        // OnDisbale : ��ü�� ��Ȱ��ȭ �Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        // OnDestroy : ��ü�� �����Ǿ��� �� ȣ��Ǵ� �̺�Ʈ �Լ��Դϴ�.

        Debug.Log("OnDestroy");
    }

}
