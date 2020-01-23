﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patron_Spawner : MonoBehaviour
{
    public GameObject patron;
    public bool stopSpawning = false;
    public float secSpawnTime;
    public float secSpawnDelay;
    public GameObject[] chairs;
    private GameObject observer;
    // Start is called before the first frame update
    void Start()
    {
        observer = GameObject.Find("Observer");
        StartCoroutine(spawnPatron());
    }

    // Update is called once per frame
    void Update()
    {
        chairs = observer.GetComponent<Observer_Data>().openSeats;
        if (chairs.Length <= 0)
        {
            stopSpawning = true;
        }
        else
        {
            stopSpawning = false;
        }
    }
    IEnumerator spawnPatron()
    {
        while (!stopSpawning)
        {
            Instantiate(patron, transform.position, transform.rotation);
            yield return new WaitForSeconds(secSpawnDelay);
        }
        
        //yield return new WaitForSeconds(secSpawnDelay);
        
    }
}
