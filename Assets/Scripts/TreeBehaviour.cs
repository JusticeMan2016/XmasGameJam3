using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Christmas
{
    public class TreeBehaviour : MonoBehaviour
    {
        public int treeHealthLeft, treeHealthRight, maxTreeHealth;
        private SpriteRenderer spriteRend;
        public Sprite sprite0, sprite1, sprite2, sprite3, spriteEnd;
        public GameObject player, tree, tree2;
        private int leftCut, rightCut;
        bool exists = false;


        // Use this for initialization
        void Start()
        {
            spriteRend = GetComponent<SpriteRenderer>();
            spriteRend.sprite = sprite0;
            
        }

        // Update is called once per frame
        void Update()
        {
            leftCut = player.GetComponent<Movement>().CutLeft;
            rightCut = player.GetComponent<Movement>().CutRight;

            if (leftCut > treeHealthLeft && rightCut < treeHealthRight)
            {
                spriteRend.sprite = sprite1;
            }

            if (leftCut < treeHealthLeft && rightCut > treeHealthRight)
            {
                spriteRend.sprite = sprite2;
            }

            if (leftCut > treeHealthLeft && rightCut > treeHealthRight)
            {
                spriteRend.sprite = sprite3;
                int temp = leftCut + rightCut;

                if (maxTreeHealth < temp && (leftCut > (treeHealthLeft+5)) && (rightCut > (treeHealthRight +5)))
                {
                    spriteRend.sprite = spriteEnd;
                    if(exists == false)
                    {
                        Instantiate(tree2);
                        exists = true;
                    }
                    
                }
            }

        }
    }
}