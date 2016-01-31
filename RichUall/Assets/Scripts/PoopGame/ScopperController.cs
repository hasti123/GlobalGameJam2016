using UnityEngine;
using System.Collections;

public class ScopperController : MonoBehaviour {

    public float moveSpeed;

    // Update is called once per frame
    void Update()
    {
        var x = GetComponent<Rigidbody2D>().position.x;
        var y = GetComponent<Rigidbody2D>().position.y;

        if (Input.GetAxis("Vertical") > 0)
        {
            y += moveSpeed;
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            y -= moveSpeed;
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            x -= moveSpeed;
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
            x += moveSpeed;
        }

        GetComponent<Rigidbody2D>().position = new Vector2(x, y);
    }
}
