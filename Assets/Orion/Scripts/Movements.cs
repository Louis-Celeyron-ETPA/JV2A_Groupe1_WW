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
<<<<<<< HEAD
        //public Sprite newSprite;
=======
        public Sprite newSprite;
>>>>>>> fd0820e8af65439f982e5437193aa8a3b3b374eb

        public float upSpeed = 1f;
        public float downSpeed = 1f;
        public float scrollSpeed = 1f;
        public float deflatingScrollSpeed = 1f;
        public float deflatingDownSpeed = 1f;


        public float airLeft = 1000f;
        public float airConsumption = 1f;

        public bool isDeflated = false;
        public bool deflationDone = false;


        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            myTransform.position += Vector3.right * scrollSpeed;
<<<<<<< HEAD
            myTransform.position -= Vector3.up * downSpeed;

            //void Move()
            //{
            //    if(airLeft > 0)
            //    {
            //        myTransform.position += Vector3.up * upSpeed;
            //        airLeft -= airConsumption;
            //    }
            //}

            if (Input.GetKey(KeyCode.Space) && airLeft > 0f)
            {
                myTransform.position += Vector3.up * upSpeed;
                airLeft -= airConsumption;
            }
            else
            {
                myTransform.position -= Vector3.up * downSpeed;
            }
=======

            myTransform.position -= Vector3.up * downSpeed;


            //if (Input.GetKey(KeyCode.Space) && airLeft > 0f)
            //{
            //        myTransform.position += Vector3.up * upSpeed;
            //        airLeft -= airConsumption;
            //}
            //else
            //{
            //    myTransform.position -= Vector3.up * downSpeed;
            //}
>>>>>>> fd0820e8af65439f982e5437193aa8a3b3b374eb

            if (airLeft <= 0)
            {
                isDeflated = true;
            }

            if (isDeflated && !deflationDone)
            {
                airLeft = 0;
<<<<<<< HEAD
                //spriteRenderer.sprite = newSprite;
=======
                spriteRenderer.sprite = newSprite;
>>>>>>> fd0820e8af65439f982e5437193aa8a3b3b374eb
                downSpeed = downSpeed * deflatingDownSpeed;
                scrollSpeed = scrollSpeed * deflatingScrollSpeed;
                deflationDone = true;
            }
        }
<<<<<<< HEAD
    }
}
=======

        public void Move()
        {
            if (airLeft > 0f)
            {
                myTransform.position += Vector3.up * upSpeed;
                airLeft -= airConsumption;
            }
        }

    }
}

>>>>>>> fd0820e8af65439f982e5437193aa8a3b3b374eb
