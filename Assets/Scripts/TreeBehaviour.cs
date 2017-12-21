using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Christmas
{
    public class TreeBehaviour : MonoBehaviour
    {
        public int treeHealthLeft, treeHealthRight, maxTreeHealth, shakeTime;
        private SpriteRenderer spriteRend;
        public Sprite sprite0, sprite1, sprite2, sprite3, spriteEnd;
        public GameObject player, tree, tree2;
        private int leftCut, rightCut;
        bool exists = false;
        private Vector3 originPosition;
        private Quaternion originRotation;
        public float shake_decay = 0.002f;
        public float shake_intensity = .3f;

        private float temp_shake_intensity = 0;


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
                if (temp_shake_intensity > 0)
                {
                    transform.position = originPosition + Random.insideUnitSphere * temp_shake_intensity;
                    transform.rotation = new Quaternion(
                        originRotation.x + Random.Range(-temp_shake_intensity, temp_shake_intensity) * .2f,
                        originRotation.y + Random.Range(-temp_shake_intensity, temp_shake_intensity) * .2f,
                        originRotation.z + Random.Range(-temp_shake_intensity, temp_shake_intensity) * .2f,
                        originRotation.w + Random.Range(-temp_shake_intensity, temp_shake_intensity) * .2f);
                    temp_shake_intensity -= shake_decay;
                }
        }

        public void Shake()
        {
            originPosition = transform.position;
            originRotation = transform.rotation;
            temp_shake_intensity = shake_intensity;

        }
    }
}