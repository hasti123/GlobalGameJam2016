using UnityEngine;
using System.Collections;

public class PoopSpawner : Spawner
{
    void Start()
    {
        methodToInvoke = "PoopSpawn";
        PoopSpawn();
    }

    void PoopSpawn()
    {
        Spawn();
        PoopCounter.turdsRemaining++;
        Debug.Log(PoopCounter.turdsRemaining);
    }
}
