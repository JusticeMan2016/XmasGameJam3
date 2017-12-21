using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Animator anim;
    // Use this for initialization
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            anim.Play("Cutting");
        }
    
        if (Input.GetKey("right"))
        {
            transform.position = new Vector3( 1f, -2.6f, -1f);
            transform.localScale = new Vector3(-1f, 1f, 1f);

        }

        if(Input.GetKey("left"))
        {
            transform.position = new Vector3(-1f, -2.6f, -1f);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
