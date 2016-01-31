using UnityEngine;
using System.Collections;

public class SnuggleController : MonoBehaviour
{
    public float directionChangeTimer;
    public float speed;

	// Use this for initialization
	void Start ()
	{
	    Move();
	}

    public void Move()
    {
        Invoke("Move", directionChangeTimer);

        var rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.velocity = new Vector2(Random.Range(-speed, speed), Random.Range(-speed, speed));
    }
}
