using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public float highestSpawnTime = 7;
    public float lowestSpawnTime = 3;
    public float heightOffset = 2;
    private float timer;
    private float spawnRate;
    public GameObject pipe;
    // Start is called before the first frame update
    void Start()
    {
        spawnRate = Random.Range(lowestSpawnTime, highestSpawnTime);
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
            spawnRate = Random.Range(lowestSpawnTime, highestSpawnTime);
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint)), transform.rotation);
    }
}
