﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour {
    public float velocity;
    Rigidbody2D rb;
    bool started;
    Collider2D collide;
    GameObject ob;
    public float deathTimer;
    bool dying;
    GameObject spawner;
    public float speed;
    
    private AudioSource audioSource;
    public AudioClip audioHit;

    //Sprites
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;
    public Sprite sprite7;
    public Sprite sprite8;
    public Sprite sprite9;
    public Sprite sprite10;
    public Sprite sprite11;

    int selectedSprite;

	// Use this for initialization
	void Start () {
        ob = this.gameObject;
        rb = ob.GetComponent<Rigidbody2D>();
        spawner = GameObject.Find("LeftSpawner");
        speed = Random.Range(-20, 20);
        velocity += spawner.gameObject.GetComponent<Spawner>().speedUp;

        audioSource = GetComponent<AudioSource>();

        SwitchSprite();

        if(ob.transform.position.x < 0)
        {
            rb.AddForce(new Vector2(velocity,0));
            //started = true;
        }
        else if (ob.transform.position.x > 0)
        {
            velocity = velocity * -1;
            rb.AddForce(new Vector2(velocity, 0));
            //started = true;
        }
		
	}

    
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Player")
        {
            //Game over
			//THIS DOES NOT WORK FOR THE GAME OVER SECTION
        }
        else if (coll.gameObject.name == "Tree")
        {
            //rb.velocity = rb.velocity * -2;
            rb.AddForce(new Vector2(velocity * -4, Random.Range(-320, 320)));
            dying = true;
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "Player" && !dying)
        {
            //Game over
            print("Player is a massive scub and died.");
			//You are send to the GameOver Screen
			SceneManager.LoadScene (2);
            audioSource.clip = audioHit;
            audioSource.Play();
        }
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.forward, speed);

        if (dying)
        {
            deathTimer -= Time.deltaTime;

        }

        if (deathTimer <= 0)
        {
            Destroy(this.gameObject);
        }
	}

    void SwitchSprite()
    {
        selectedSprite = Random.Range(0, 12);

        switch (selectedSprite)
        {
            case 1:
                {
                    this.GetComponent<SpriteRenderer>().sprite = sprite1;
                    break;
                }
            case 2:
                {
                    this.GetComponent<SpriteRenderer>().sprite = sprite2;
                    break;
                }
            case 3:
                {
                    this.GetComponent<SpriteRenderer>().sprite = sprite3;
                    break;
                }
            case 4:
                {
                    this.GetComponent<SpriteRenderer>().sprite = sprite4;
                    break;
                }
            case 5:
                {
                    this.GetComponent<SpriteRenderer>().sprite = sprite5;
                    break;
                }
            case 6:
                {
                    this.GetComponent<SpriteRenderer>().sprite = sprite6;
                    break;
                }
            case 7:
                {
                    this.GetComponent<SpriteRenderer>().sprite = sprite7;
                    break;
                }
            case 8:
                {
                    this.GetComponent<SpriteRenderer>().sprite = sprite8;
                    break;
                }
            case 9:
                {
                    this.GetComponent<SpriteRenderer>().sprite = sprite9;
                    break;
                }
            case 10:
                {
                    this.GetComponent<SpriteRenderer>().sprite = sprite10;
                    break;
                }
            case 11:
                {
                    this.GetComponent<SpriteRenderer>().sprite = sprite11;
                    break;
                }
        }
    }

}
