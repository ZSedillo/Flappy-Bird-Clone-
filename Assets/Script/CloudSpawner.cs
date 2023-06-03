using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudSpawner : MonoBehaviour
{
    public GameObject cloud;
    public float spawnRate = 4;
    private float timer = 0;
    private float heightOffSet = 2;
    // Start is called before the first frame update
    void Start()
    {
        spawnCloud();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer <= spawnRate)
        {
            timer += Time.deltaTime;
        }
        else {
            spawnCloud();
            timer = 0;
        }
    }

    void spawnCloud() {
        float highestPoint = transform.position.y + heightOffSet;
        float lowestPoint = transform.position.y - heightOffSet;
        Instantiate(cloud,new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),0),transform.rotation);
    }
}
