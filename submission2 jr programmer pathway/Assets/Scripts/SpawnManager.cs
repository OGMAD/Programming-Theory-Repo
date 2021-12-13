using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] List<GameObject> walls;
    private Vector3[] spawnPos = { new Vector3(3.5f, 0.5f, 150.0f), new Vector3(0.0f, 0.5f, 150.0f), new Vector3(-3.5f, 0.5f, 150.0f)};
    private float startDelay = 1;
    private float repeatRate = 1;
    private int randomPos;
    private int randomWall;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnWall", startDelay, repeatRate);
    }

    void SpawnWall()
    {
        randomPos = Random.Range(0, spawnPos.Length);
        randomWall = Random.Range(0, walls.Capacity);
        Instantiate(walls[randomWall], spawnPos[randomPos], walls[randomWall].transform.rotation);
    }
}
