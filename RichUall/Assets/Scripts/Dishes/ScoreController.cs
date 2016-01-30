using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

	private Text _score;

	// Use this for initialization
	void Start () {
		_score = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetScore(int score) {
		_score.text = string.Format ("Score: {0}", score);
	}
}
