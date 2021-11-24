using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;

    private float spawnRange = 10;
    // Start is called before the first frame update
    void Start()
    {
        float spawnPosX = Random.Range(-15, 15);
        float spawnPosZ = Random.Range(22, 50);
        Instantiate(enemyPrefab, new Vector3(spawnPosX, 0, spawnPosZ), enemyPrefab.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
