using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UINamePersonalizer : MonoBehaviour
{

	//Your name being displayed at the end
	public Text yourName;

	// Use this for initialization
	void Start () {
		//Personalizes the message at the endscreen
		yourName.text = "Naughty  " + PlayerPrefs.GetString("Your Name");
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

