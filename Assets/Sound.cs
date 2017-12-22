using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour {
    private AudioSource audioSource;
    public AudioClip[] chops;
    private AudioClip chop;
    
	// Use this for initialization
	void Start () {
        audioSource = gameObject.GetComponent<AudioSource>();
    }
	
    public void PlaySounds()
    {
        int Index = Random.Range(0, chops.Length);
        chop = chops[Index];
        audioSource.clip = chop;
        audioSource.Play();
        gameObject.GetComponent<ParticleSystem>().Play();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PlaySounds();

        }
    }
}
