using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public GameObject[] itemPrefabs; 
    public float minTime = 1f;
    public float maxTime = 2f;

    void Start()
    {
        StartCoroutine(SpawnCoRutine(0));    
    }       

    IEnumerator SpawnCoRutine(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        
        int indiceAleatorio = Random.Range(0, itemPrefabs.Length);
        
        Instantiate(itemPrefabs[indiceAleatorio], transform.position, Quaternion.identity);
        
        StartCoroutine(SpawnCoRutine(Random.Range(minTime, maxTime)));
    }
}