using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HandController : MonoBehaviour {
	public float HandSpeed;
	public int PlayerScore;
    public int winningScore;
    public string sceneToLoad;
    private ScoreController _scoreText;
    
	// Use this for initialization
	void Start () {
		GameObject g = GameObject.Find("Score");
		_scoreText = g.GetComponent<ScoreController> ();
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
		PlayerScore++;
		_scoreText.SetScore (PlayerScore);

	    if (PlayerScore >= winningScore)
	    {
	        SceneManager.LoadScene(sceneToLoad);
	    }
	}
}
