﻿using UnityEngine;
using System.Collections;

public class InteractiveObjectController : MonoBehaviour {

	private bool _characterInRange;
	private int _keyPressDuration;
	private bool _eggFried;
	// Use this for initialization
	void Start () {
		_characterInRange = false;
		_eggFried = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate() {
		UpdateEggFryer ();
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		_characterInRange = true;

	}

	void OnTriggerExit2D(Collider2D other) 
	{
		_characterInRange = false;
	}

	void UpdateEggFryer(){
		if (_characterInRange && !_eggFried) {
			if (Input.GetKey (KeyCode.E)) {
				_keyPressDuration += 1;
				Debug.Log (_keyPressDuration);
				if (_keyPressDuration == 500) {
					_eggFried = true;
					Debug.Log ("Egg made");
					_keyPressDuration = 0;
				}
			} else {
				DecreaseWalterDuration ();
			}
		} else {
			DecreaseWalterDuration ();
		}
	}

	void DecreaseWalterDuration() {
		if (_keyPressDuration > 0) {
			_keyPressDuration -= 1;
			Debug.Log (_keyPressDuration);
		}
	}
}