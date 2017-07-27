using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)){
			RestartGame();
		}
		if (Input.GetKeyDown(KeyCode.Q)){
			QuitGame();
		}	
	}

	void BeginGame(){
		return;
	}

	void PauseGame(){
		return;
	}

	void RestartGame(){
		BeginGame();
		return;
	}

	void QuitGame(){
		Debug.Log("Quit Game\n");
		Application.Quit();
		return;
	}
}
