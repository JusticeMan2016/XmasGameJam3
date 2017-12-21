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

	//Your name being displayed at the end
	public Text yourName;

	// Use this for initialization
	void Start () {
		//Personalizes the message at the endscreen
		yourName.text = "Naughty  " + PlayerPrefs.GetString("Your Name");
	}

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

	public void OnReplay(){
		//Go back to the game
		SceneManager.LoadScene(1);
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
