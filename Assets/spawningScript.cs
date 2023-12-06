using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawningScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 5;
    public float heightOffset = 10;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        spawnRate = 4;
        timer = 0;
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;

        Vector3 randomHeight = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z);

        Instantiate(pipe, randomHeight, transform.rotation);
    }
}
