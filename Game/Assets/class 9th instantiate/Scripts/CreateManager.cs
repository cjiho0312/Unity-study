using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] List <GameObject> monsterList;
    [SerializeField] int count;
    [SerializeField] float time;

    int monsterEvent;


    void Start()
    {
        Initialized();
        time = 0;
        monsterEvent = 0;
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

    private void Update()
    {
        time += Time.deltaTime;

        if (time >= 5.0f)
        {
            Debug.Log("Call");
            
            if (monsterEvent < count)
            {
                monsterList[monsterEvent].SetActive(true);
                monsterEvent++;
            }

            time = 0;
        }

    }
}