using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] thingsToSpawn;
    public float width;
    public float height;
    public float spawnDelay;
    public float x;
    public float y;

    protected string methodToInvoke;
     
	// Use this for initialization
	void Start ()
	{
	    methodToInvoke = "Spawn";
	    Spawn();
	}

	protected void Spawn ()
	{
        Invoke(methodToInvoke, spawnDelay);

	    var objectX = gameObject.transform.position.x + x;
	    var objectY = gameObject.transform.position.y + y;

        Instantiate(thingsToSpawn[Random.Range(0, thingsToSpawn.Length - 1)], 
            new Vector3(Random.Range(objectX, objectX + width), Random.Range(objectY, objectY + height)), 
            Quaternion.identity);
	}
}
