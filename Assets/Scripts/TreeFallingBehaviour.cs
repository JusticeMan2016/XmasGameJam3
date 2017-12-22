using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TreeFallingBehaviour : MonoBehaviour {

    public int force;

    private AudioSource audioSource;
    public AudioClip audioHit;

	//timer variables
	bool countDown = false;
	public float timerOver = 6f;

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody2D>().AddForce(new Vector2(force, 0));
        audioSource = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {

		if (countDown == true)
		{
			timerOver -= Time.deltaTime;
			print("The countdown is initiated.");
		}

		if (timerOver <= 0)
		{
			//You are send to the EndScene
			//You have been VICTORIOUS!
			print("Player has saved the day.");
			SceneManager.LoadScene (3);
		}
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		if (coll.gameObject.name == "Ground")
		{
			//Load scene after ground hit
			countDown = true;
		}
	}
}
