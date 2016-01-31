using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ClockController : MonoBehaviour {

	private float _timeRemaining;
	private PersistentDataScript _persistentData;
	private Text _clock;
	// Use this for initialization
	void Start () {
		var persistentData = GameObject.Find ("PersistentData");
		_persistentData = persistentData.GetComponent<PersistentDataScript> ();
		//_clock = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		_timeRemaining = (int)_persistentData.TimeRemaining;
		//_clock.text = string.Format("Bus arrives in {0} seconds", _timeRemaining);
	}
}
