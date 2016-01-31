using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject[] thingsToSpawn;
    public float width;
    public float height;
    public float spawnDelay;
     
	// Use this for initialization
	void Start ()
	{
	    Spawn();
	}

	void Spawn ()
	{
        Invoke("Spawn", spawnDelay);

	    var objectX = gameObject.transform.position.x;
	    var objectY = gameObject.transform.position.y;

        Instantiate(thingsToSpawn[Random.Range(0, thingsToSpawn.Length - 1)], 
            new Vector3(Random.Range(objectX, objectX + width), Random.Range(objectY, objectY + height)), 
            Quaternion.identity);
	}
}
