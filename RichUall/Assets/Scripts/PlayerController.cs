using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		var x = GetComponent<Rigidbody2D> ().position.x;
		var y = GetComponent<Rigidbody2D> ().position.y;

	    if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
	    {
			y += moveSpeed;
	    }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            y -= moveSpeed;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
			x -= moveSpeed;
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
			x += moveSpeed;
        }

		GetComponent<Rigidbody2D>().position = new Vector2(x, y);
    }
}
