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
	    if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
	    {
            GetComponent<Rigidbody2D>().position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + moveSpeed);
	    }

        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            GetComponent<Rigidbody2D>().position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - moveSpeed);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().position = new Vector3(gameObject.transform.position.x - moveSpeed, gameObject.transform.position.y);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().position = new Vector3(gameObject.transform.position.x + moveSpeed, gameObject.transform.position.y);
        }
    }
}
