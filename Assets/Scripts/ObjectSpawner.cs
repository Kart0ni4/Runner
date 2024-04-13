using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform[] spawnPoints;
    IEnumerator Start()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(1, 2)); 

            int spawnPointIndex = Random.Range(0, spawnPoints.Length); 

            Instantiate(objectToSpawn, spawnPoints[spawnPointIndex].position, Quaternion.identity); 
        }
    }
}

