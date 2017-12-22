using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow : MonoBehaviour {
    ParticleSystem ps;
    Color color;
    float colorChange = 1;
    float colorChanger = 1;
    float colorChangeb = 1;
    float colorChangeg = 1;
    int hits = 0;


	// Use this for initialization
	void Start () {
        ps = this.GetComponent<ParticleSystem>();


	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space") && colorChange > 0)
        {
            //Darkmode
            /*
            colorChange -= 0.05f;
            color = new Color(colorChange, colorChange, colorChange);
            ps.startColor = color;
            */

            hits += 1;
        }

        if (hits > 15)
        {
            colorChanger = Random.Range(0, 1);
            colorChangeb = Random.Range(0, 1);
            colorChangeg = Random.Range(0, 1);
            color = new Color(colorChanger, colorChangeb, colorChangeg);
        }
        
		
	}
}
