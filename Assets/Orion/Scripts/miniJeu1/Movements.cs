using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{
    public class Movements : MonoBehaviour
    {
        // Start is called before the first frame update
        public Transform myTransform;
        public SpriteRenderer spriteRenderer;
        public Sprite newSprite;

        public float upSpeed = 1f;
        public float downSpeed = 1f;
        public float scrollSpeed = 1f;
        public float deflatingDownSpeed = 1f;


        public float airLeft = 1000f;
        public float airConsumption = 1f;

        public bool isDeflated = false;
        public bool deflationDone = false;


        void Start()
        {

        }

        // Update is called once per frame
        public void Move()
        {
            if (airLeft > 0)
            {
                myTransform.position += Vector3.up * upSpeed * Time.deltaTime;
                airLeft -= airConsumption;
            }
        }
        void Update()
        {
            myTransform.position -= Vector3.up * downSpeed * Time.deltaTime;

            if (airLeft <= 0)
            {
                isDeflated = true;
            }

            if (isDeflated && !deflationDone)
            {
                airLeft = 0;

                spriteRenderer.sprite = newSprite;
                downSpeed = downSpeed * deflatingDownSpeed;
                deflationDone = true;
            }
        }
    }
}


