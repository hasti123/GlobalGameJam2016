using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;

    private Animator animator;
    private bool facingRight;

	// Use this for initialization
	void Start ()
	{
	    animator = GetComponent<Animator>();
	    facingRight = false;
	}
	
	// Update is called once per frame
	void Update () {
		var x = GetComponent<Rigidbody2D> ().position.x;
		var y = GetComponent<Rigidbody2D> ().position.y;

	    if (Input.GetAxis("Vertical") > 0)
	    {
	        y += moveSpeed;
	        animator.SetFloat("MoveY", 1);
	    }

        if (Input.GetAxis("Vertical") < 0)
        {
            y -= moveSpeed;
            animator.SetFloat("MoveY", -1);
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
			x -= moveSpeed;
        }

        if (Input.GetAxis("Horizontal") > 0)
        {
			x += moveSpeed;
        }

        animator.SetFloat("MoveX", Input.GetAxis("Horizontal"));
        animator.SetFloat("MoveY", Input.GetAxis("Vertical"));
        UpdateAnimator(x, y);
        
        GetComponent<Rigidbody2D>().position = new Vector2(x, y);
    }

    private void UpdateAnimator(float x, float y)
    {
        if (x > GetComponent<Rigidbody2D>().position.x)
        {
            animator.SetFloat("MoveX", 1);
        }
        else if (x < GetComponent<Rigidbody2D>().position.x)
        {
            animator.SetFloat("MoveX", -1);
        }
        else
        {
            animator.SetFloat("MoveX", 0);
        }

        if (y > GetComponent<Rigidbody2D>().position.y)
        {
            animator.SetFloat("MoveY", 1);
        }
        else if (y < GetComponent<Rigidbody2D>().position.y)
        {
            animator.SetFloat("MoveY", -1);
        }
        else
        {
            animator.SetFloat("MoveY", 0);
        }
    }
}
