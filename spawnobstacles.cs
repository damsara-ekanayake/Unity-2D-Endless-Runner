using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnobstacles : MonoBehaviour
{
    public GameObject obstacle;
    public float maxX;
    public float maxY;
    public float minX;
    public float minY;
    public float timebetweenspawn;
    private float spawntime;
 
    // Update is called once per frame
    void Update()
    {
      
        if(Time.time > spawntime)
        {
            Spawn();
            spawntime = Time.time + timebetweenspawn;
        }

    }

    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float ramdomY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, ramdomY, 0), transform.rotation);


    }

}
