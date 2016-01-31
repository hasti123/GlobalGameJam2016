using UnityEngine;
using System.Collections;

public class StinkRemover : MonoBehaviour
{
    private PersistentDataScript persistentData;

    // Use this for initialization
	void Start () {
        var persistentDataFinder = GameObject.Find("PersistentData");
        persistentData = persistentDataFinder.GetComponent<PersistentDataScript>();
    }
	
	// Update is called once per frame
	void Update () {
	    if (persistentData.IsKittyLitterClean)
	    {
	        GameObject.Find("Litter").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("LitterMess").GetComponent<SpriteRenderer>().enabled = false;
        }

        if (persistentData.AreDishesDone)
        {
            GameObject.Find("Sink").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("KitchenMess").GetComponent<SpriteRenderer>().enabled = false;
        }

        if (persistentData.IsBedDone)
        {
            GameObject.Find("Bed").GetComponent<SpriteRenderer>().enabled = false;
            GameObject.Find("BedMess").GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
