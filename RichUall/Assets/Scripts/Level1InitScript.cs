using UnityEngine;
using System.Collections;

public class Level1InitScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		var pData = GameObject.Find ("PersistentData");
		var persistentData = pData.GetComponent<PersistentDataScript> ();
		persistentData.gameStarted = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
