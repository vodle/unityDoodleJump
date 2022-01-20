using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformGenerator : MonoBehaviour
{
    public GameObject platformPrefab;
    void Start()
    {
        Vector3 spawnPos = new Vector3();

        for (int i = 0; i < 10; i++)
        {
            spawnPos.x = Random.Range(-2f, 2f);
            spawnPos.y += Random.Range(1.5f, 2.5f);

            Instantiate(platformPrefab, spawnPos, Quaternion.identity);
        }
        
    }


    void Update()
    {
        
    }
}
