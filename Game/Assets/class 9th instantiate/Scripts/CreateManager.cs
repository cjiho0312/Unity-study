using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] List <GameObject> monsterList;
    [SerializeField] int count;
    int activeMonster;
    int index;

    void Start()
    {
        Initialized();

        StartCoroutine(Coroutine());

    }

    private void Initialized()
    {
        monsterList.Capacity = 10;  
        
        for (int i = 0; i < count; i++)
        {
            GameObject newPrefab = Instantiate(prefab, gameObject.transform); // CreateManager의 자식으로 생성

            newPrefab.SetActive(false);

            monsterList.Add(newPrefab);
        }
    }

    IEnumerator Coroutine()
    {
        activeMonster = 0;

        while (true)
        {
            yield return new WaitForSeconds(5.0f);

            index = Random.Range(0, count);

            if (activeMonster == count)
            {
                Debug.Log("Exit");
                yield break;
            }

            if (monsterList[index].activeSelf == true)
            {
                while (monsterList[index].activeSelf == true)
                {
                    if (index >= count - 1)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                }
            }

            monsterList[index].SetActive(true);

            activeMonster++;
        }
    }
}