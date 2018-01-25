using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] private GameObject SpawnObj;
    [SerializeField] private Transform spawnPoint;

    [SerializeField] float interval = 20f;
    float cachedInterval;
    
    [SerializeField] int count = 3;

    void Start()
    {
        cachedInterval = interval;
    }

    void Update()
    {
        interval -= 1 * Time.deltaTime;

        if (interval < 0 && spawnPoint.childCount < count)
        {
            Instantiate(SpawnObj, spawnPoint.position, spawnPoint.rotation, spawnPoint);
            interval = cachedInterval;
        }
        
    }
}
