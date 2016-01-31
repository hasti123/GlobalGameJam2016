using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PersistentDataScript : MonoBehaviour {

	public float TimeRemaining { get; set; }
	public bool IsBedDone { get; set; }
	public bool AreDishesDone { get; set; }
	public bool IsKittyLitterClean { get; set; }
	public bool gameStarted { get; set; }

    public float RichX { get; set; }

    public float RichY { get; set; }

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
		IsBedDone = false;
		AreDishesDone = false;
		IsKittyLitterClean = false;
		gameStarted = false;
		TimeRemaining = PlayerPrefs.GetInt ("TimeRemaining");
	    RichX = -7;
	    RichY = 2;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (gameStarted) {
			if (TimeRemaining >= 0) {
				CountdownTimeRemaining ();
			} else
			{
			    gameStarted = false;
				SceneManager.LoadScene("MainMenu");
                Destroy(gameObject);
			}
		}
	}

	void CountdownTimeRemaining()
	{
		TimeRemaining -= Time.deltaTime;
	}
}
