using UnityEngine;
using System.Collections;

public class HandController : MonoBehaviour {
	public float HandSpeed;
	private int _dishesCaught;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		var x = GetComponent<Rigidbody2D> ().position.x; 

		if (Input.GetAxis ("Horizontal") < 0) {
			x -= HandSpeed;
		}
		if (Input.GetAxis ("Horizontal") > 0) {
			x += HandSpeed;
		}

		GetComponent<Rigidbody2D>().position = new Vector2(x, GetComponent<Rigidbody2D>().position.y);
	}

	void OnTriggerEnter2D(Collider2D other) {
		Destroy (other.gameObject);
		_dishesCaught += 1;
	}
}
