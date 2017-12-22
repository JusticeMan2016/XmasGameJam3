using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour {

	//Name Input Field
	public InputField nameField;

	//Error Message
	public Transform errorMessage;

	//Person's name string
	private string charName;

	//If you press on the start button
	public void OnStart(){
		//Set charName string to text in nameField, saving this in PlayerPrefs
		if (nameField.text != "") {
			charName = nameField.text;
			PlayerPrefs.SetString ("Your Name", charName);
			Debug.Log("Your name is " + charName);
			//Let's play the game!
			SceneManager.LoadScene(1);
		} else {
			errorMessage.gameObject.SetActive (true);
			Debug.Log ("You have no name");
		}
	}

	//If you press on the How To Play button
	public void OnHelp(){
		SceneManager.LoadScene (4);
	}

	//If you press on the Play Again button
	public void OnReplay(){
		//Go back to the game
		SceneManager.LoadScene(1);
	}

	//If you press on the Go Back to Menu button
	public void OnReturnMenu(){
		SceneManager.LoadScene (0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
