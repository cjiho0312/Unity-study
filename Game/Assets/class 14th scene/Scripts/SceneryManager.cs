using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneryManager : MonoBehaviour
{
    [SerializeField] GameObject Loadscreen;
    [SerializeField] Slider progress;
    [SerializeField] float displayProgress;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    /*
    public void SceneMove(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex); // 이름(string)으로도 접근 가능, 씬 인덱스(int)로도 접근 가능
    }
    */


    public void SceneMove(int buildIndex)
    {
        StartCoroutine(TransitionScene(buildIndex));
    }

    public IEnumerator TransitionScene(int index)
    {
        progress.value = 0;
        displayProgress = 0;
        Loadscreen.SetActive(true);

        // <AsyncOperation>

        // - allowSceneActivation
        // 장면이 준비되는 즉시 장면이 활성화 되는 것을 허용하는 변수입니다.

        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(index);
        asyncOperation.allowSceneActivation = false;

        // - isDone
        // 해당 동작이 완료되었는지 나타내는 변수입니다. (읽기 전용)

        while (asyncOperation.isDone == false)
        { 

            displayProgress = Mathf.Lerp(progress.value, 1.0f, Time.deltaTime);
            // - progress
            // 작업의 진행 상태를 나타내는 변수입니다. (읽기 전용)

            if (asyncOperation.progress >= 0.9f)
            {
                displayProgress = Mathf.Lerp(progress.value, 1.0f, Time.deltaTime);

                if (progress.value >= 0.99f)
                {
                    asyncOperation.allowSceneActivation = true;
                }
            }

            progress.value = displayProgress;

            yield return null;
        }
        
        Loadscreen.SetActive(false);
    }


}
