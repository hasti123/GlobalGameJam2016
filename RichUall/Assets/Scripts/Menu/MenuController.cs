﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	public Canvas quitMenu;
	public Button startText;
	public Button exitText;

	// Use this for initialization
	void Start () {
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startText = startText.GetComponent<Button> ();
		exitText = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
	}
	
	public void ExitPress() {
		quitMenu.enabled = true; 
		startText.enabled = false;
		exitText.enabled = false;
	}

	public void NoPress() {
		quitMenu.enabled = false; 
		startText.enabled = true;
		exitText.enabled = true;
	}

	public void StartLevel() {
		SceneManager.LoadScene ("Bedroom");
	}

	public void ExitGame() {
		Application.Quit ();
	}
}