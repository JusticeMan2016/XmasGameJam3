using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public float velocity;
    Rigidbody2D rb;
    bool started;
    Collider2D collide;
    GameObject ob;
    public float deathTimer;
    bool dying;

    GameObject spawner;

	// Use this for initialization
	void Start () {
        ob = this.gameObject;
        rb = ob.GetComponent<Rigidbody2D>();
        spawner = GameObject.Find("LeftSpawner");

        velocity += spawner.gameObject.GetComponent<Spawner>().speedUp;

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
        }
        else if (coll.gameObject.name == "Tree")
        {
            //rb.velocity = rb.velocity * -2;
            rb.AddForce(new Vector2(velocity * -2, 0));
            dying = true;
        }

    }
	
	// Update is called once per frame
	void Update () {

        if (dying)
        {
            deathTimer -= Time.deltaTime;
        }

        if (deathTimer <= 0)
        {
            Destroy(this.gameObject);
        }
	}
}
