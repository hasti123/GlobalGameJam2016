using UnityEngine;
using System.Collections;

public class DishController : MonoBehaviour
{

    public float fallSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y - fallSpeed);
	}
}
