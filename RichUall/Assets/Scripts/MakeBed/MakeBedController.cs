using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MakeBedController : MonoBehaviour
{
    public int winningFluffs;
    private int _fluffs = 0;
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown(KeyCode.E))
	    {
	        _fluffs++;
	    }

	    if (_fluffs >= winningFluffs)
	    {
            var persistentDataFinder = GameObject.Find("PersistentData");
            var persistentData = persistentDataFinder.GetComponent<PersistentDataScript>();

            //Consider the pillow fluffed
            persistentData.IsBedDone = true;

            SceneManager.LoadScene("Bedroom");
	    }
	}
}
