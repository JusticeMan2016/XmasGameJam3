﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject prefab;
    public float timer;
    public float speedUpTimer;
    float ogspeedUpTimer;

    public int minSpawnTime;
    public int maxSpawnTime;

    public double halvedMaxTime;
    GameObject spawner;
    GameObject lspawner;
    GameObject rspawner;
    public bool isLeft;

    public float speedUpCounter;
    float ogSpeedUpCounter;
    public int speedUp = 0;

	// Use this for initialization
	void Start () {
        timer = Random.Range(5, 15);
        ogspeedUpTimer = speedUpTimer;
        ogSpeedUpCounter = speedUpCounter;

        //halvedMaxTime = maxSpawnTime / 2;
        if (isLeft)
        {
            spawner = GameObject.Find("RightSpawner");
            rspawner = GameObject.Find("RightSpawner");
        }
        else
        {
            spawner = GameObject.Find("LeftSpawner");
            lspawner = GameObject.Find("LeftSpawner");
        }
	}
	
	// Update is called once per frame
	void Update () {

        if (lspawner != null)
        {
            if (lspawner.GetComponent<Spawner>().timer - timer < 2f && lspawner.GetComponent<Spawner>().timer - timer > 0f)
            {
                lspawner.GetComponent<Spawner>().timer += 1f;
                //print("Time have been added");
            }
        }

        if (timer <= 0)
        {
            Instantiate(prefab, transform.position, transform.rotation);
            timer = Random.Range(minSpawnTime, maxSpawnTime);
        }

        if (speedUpTimer <= 0 && maxSpawnTime >= halvedMaxTime)
        {
            maxSpawnTime -= 1;
            speedUpTimer = ogspeedUpTimer;
        }

        if (speedUpCounter <= 0)
        {
            speedUp += 1;
            speedUpCounter = ogSpeedUpCounter;
        }


        timer -= Time.deltaTime;
        speedUpTimer -= Time.deltaTime;
        speedUpCounter -= Time.deltaTime;

	}
}
