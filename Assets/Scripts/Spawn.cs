using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject[] spawnPrefab;

    [SerializeField] float secondSpawn = 0.4f, minTras, maxTras;

    void Start()
    {
        StartCoroutine(TriggerSpawn());
    }

    IEnumerator TriggerSpawn()
    {
        while (true)
        {
            var wanted = Random.Range(minTras, maxTras);
            var position = new Vector3(wanted, transform.position.y);
            GameObject gameObject = Instantiate(spawnPrefab[Random.Range(0, spawnPrefab.Length)], position, Quaternion.identity);
            yield return new WaitForSeconds(secondSpawn);
            Destroy(gameObject, 5f);
        }
    }
}
