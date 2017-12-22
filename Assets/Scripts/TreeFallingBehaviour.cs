using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeFallingBehaviour : MonoBehaviour {

    public int force;

    private AudioSource audioSource;
    public AudioClip audioHit;

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody2D>().AddForce(new Vector2(force, 0));
        audioSource = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
