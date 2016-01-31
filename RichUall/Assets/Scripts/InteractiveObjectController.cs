using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class InteractiveObjectController : MonoBehaviour
{
    public string transitionLevel;
    public int transitionTimer;
    public GameObject rich;

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
			if (Input.anyKey) {
				_keyPressDuration += 1;
				Debug.Log (_keyPressDuration);
				if (_keyPressDuration == transitionTimer) {
					_eggFried = true;
					Debug.Log ("Egg made");
					_keyPressDuration = 0;

                    var persistentDataFinder = GameObject.Find("PersistentData");
                    var persistentData = persistentDataFinder.GetComponent<PersistentDataScript>();

                    //Consider the pillow fluffed
                    persistentData.RichX = rich.transform.position.x;
				    persistentData.RichY = rich.transform.position.y;

                    SceneManager.LoadScene(transitionLevel);
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
