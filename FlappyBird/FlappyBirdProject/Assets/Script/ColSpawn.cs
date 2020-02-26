using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColSpawn : MonoBehaviour {

    public int colPoolSize = 5;
    public GameObject colPrefab;
    public float spawnRate = 4f;
    public float colMin = -2f;
    public float colMax = 2f;

    private GameObject[] cols;
    Vector2 objectPoolPosition = new Vector2(-15f, 25f);
    float timeSinceLastSpawned;
    float spawnXPosition = 6f;
    int currentCol = 0;

    void Start () {
        cols = new GameObject[colPoolSize];
        for (int i = 0; i < colPoolSize; i++)
        {
            cols[i] = (GameObject)Instantiate(colPrefab,objectPoolPosition,Quaternion.identity);           
        }
	}
	
	void Update () {
        timeSinceLastSpawned += Time.deltaTime;
        if (timeSinceLastSpawned >= spawnRate)
        {
            timeSinceLastSpawned = 0;
            float spawnYPosition = Random.Range(colMin, colMax);
            cols[currentCol].transform.position = new Vector2(spawnXPosition,spawnYPosition);
            currentCol++;
            if (currentCol >= colPoolSize)
            {
                currentCol = 0;
            }
        }
	}
}
