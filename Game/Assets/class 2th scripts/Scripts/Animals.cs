using UnityEngine;

public class Animals : MonoBehaviour
{
    [SerializeField] Ability ability;

    private void Awake()
    {
        // Awake : 객체가 생성될 때 호출되는 함수로, 객체가 비활성화 되어있을 때에도
        //         호출되고, 단 한 번만 호출되는 이벤트 함수입니다.

        // Start, OnEnable 전에 실행되는 함수. 데이터를 불러올 때 사용할 수 있음.

        Debug.Log("Awake");

        Debug.Log(ability.Strength);
    }

    private void OnEnable()
    {
        // OnEnable : 객체가 활성화 되었을 때 호출되는 이벤트 함수입니다.

        // 비활성화 했다가 다시 활성화할 때마다 또 호출되기 때문에, 이벤트를 등록할 때 사용함.

        Debug.Log("OnEnable");
    }

    void Start()
    {
        // Start : 객체가 생성되었을 때 호출되며, 단 한 번만 호출되는 이벤트 함수입니다.

        Debug.Log("Start");
    }

    private void FixedUpdate()
    {
        // FixedUpdate : Time Step에 설정된 값에 따라 일정한 간격으로 호출되는 이벤트 함수입니다.

        Debug.Log("Fixed update");
    }

    void Update()
    {
        // Update : 객체가 활성화되는 동안, 매 프레임마다 호출되는 이벤트 함수입니다.

        Debug.Log("Update");
    }

    private void LateUpdate()
    {
        // LateUpdate : 한 프레임의 마지막 단계에서 호출되는 이벤트 함수입니다.

        // 팔로우 카메라 시스템 등에 사용할 수 있음.

        Debug.Log("Late update");
    }

    private void OnDisable()
    {
        // OnDisbale : 객체가 비활성화 되었을 때 호출되는 이벤트 함수입니다.

        Debug.Log("OnDisable");
    }

    private void OnDestroy()
    {
        // OnDestroy : 객체가 삭제되었을 때 호출되는 이벤트 함수입니다.

        Debug.Log("OnDestroy");
    }

}
