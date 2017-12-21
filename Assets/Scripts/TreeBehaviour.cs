using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Christmas
{
    public class TreeBehaviour : MonoBehaviour
    {
        public int treeHealthLeft, treeHealthRight;
        private SpriteRenderer spriteRend;
        public Sprite sprite0, sprite1, sprite2, sprite3;
        public GameObject player;

        // Use this for initialization
        void Start()
        {
            spriteRend = GetComponent<SpriteRenderer>();
            spriteRend.sprite = sprite0;
        }

        // Update is called once per frame
        void Update()
        {
            if(player.GetComponent<Movement>().CutLeft > treeHealthLeft && player.GetComponent<Movement>().CutRight < treeHealthRight)
            {
                spriteRend.sprite = sprite1;
            }

            if (player.GetComponent<Movement>().CutLeft < treeHealthLeft && player.GetComponent<Movement>().CutRight > treeHealthRight)
            {
                spriteRend.sprite = sprite2;
            }

            if (player.GetComponent<Movement>().CutLeft > treeHealthLeft && player.GetComponent<Movement>().CutRight > treeHealthRight)
            {
                spriteRend.sprite = sprite3;
            }

        }
    }
}