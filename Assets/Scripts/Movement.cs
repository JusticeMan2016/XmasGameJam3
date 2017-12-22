using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Christmas
{
    public class Movement : MonoBehaviour
    {

        private Animator anim;
        bool isLeft = true;
        int cutLeft, cutRight;
        public GameObject tree;
        public float time;

        public int CutLeft
        {
            get
            {
                return cutLeft;
            }
        }
        public int CutRight { get { return cutRight; } }

        // Use this for initialization
        void Start()
        {
            anim = GetComponent<Animator>();
            cutLeft = 0;
            cutRight = 0;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown("space"))
            {
                anim.Play("Cutting");
                if (isLeft == true)
                {
                    cutLeft++;
                }
                else
                {
                    cutRight++;
                }


                tree.GetComponent<TreeBehaviour>().Shake();
                Debug.Log("left Score: " + CutLeft + "\nRight Score: " + cutRight);
            }

            if (Input.GetKey("right"))
            {
                transform.position = new Vector3(1f, -2.6f, -1f);
                transform.localScale = new Vector3(-1f, 1f, 1f);
                isLeft = false;

            }

            if (Input.GetKey("left"))
            {
                transform.position = new Vector3(-1f, -2.6f, -1f);
                transform.localScale = new Vector3(1f, 1f, 1f);
                isLeft = true;
            }
        }
    }
}

