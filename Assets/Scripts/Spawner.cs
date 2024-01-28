using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject spawnedObject;
    public float spawnDelay;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;


    // the float are where you want to spawn objects
    void Start()
    {
        StartCoroutine(Spawn());
    }
    //the random spawn thing is inside here, should work in 3D world
    IEnumerator Spawn()
    {
        float spawnX = 0;
        float spawnY = 0;
        spawnX = Random.Range(xMin, xMax);
        spawnY = Random.Range(yMin, yMax);
        yield return new WaitForSeconds(spawnDelay);
        Instantiate(spawnedObject, new Vector3(spawnX, spawnY, 0), Quaternion.identity);
        StartCoroutine(Spawn());
    }
}
