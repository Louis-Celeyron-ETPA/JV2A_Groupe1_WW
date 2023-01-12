using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hugo
{
    public class Joueur : MonoBehaviour
    {
        public KeyCode myKey;
        public Transform thierry;

        public float speedMax = 0.1f;
        public float acceleration = 0.01f;
        public float tempSpeedX = 0;
        public float rotationSpeed = 1;
        public bool canMove = false;

        // Update is called once per frame
        /* void Update()
         {
             if (Input.GetKey(KeyCode.Z) == true)
             {
                 tempSpeedX += acceleration;
                 tempSpeedX = Mathf.Clamp(tempSpeedX, 0, speedMax);
                 thierry.position += Vector3.forward * tempSpeedX;
             }

             if (Input.GetKey(KeyCode.S) == true)
             {
                 tempSpeedX += acceleration;
                 tempSpeedX = Mathf.Clamp(tempSpeedX, 0, speedMax);
                 thierry.position += Vector3.back * tempSpeedX;
             }

             if (Input.GetKey(KeyCode.Q) == true)
             {
                 tempSpeedX = Mathf.Clamp(tempSpeedX, speedMax, 0);
                 thierry.position += Vector3.left * tempSpeedX;
             }

             if (Input.GetKey(KeyCode.D) == true)
             {
                 tempSpeedX += acceleration;
                 tempSpeedX = Mathf.Clamp(tempSpeedX, 0, speedMax);
                 thierry.position += Vector3.right * tempSpeedX;
             }
         }*/

        public void up()
        {
            tempSpeedX += acceleration;
            tempSpeedX = Mathf.Clamp(tempSpeedX, 0, speedMax);
            thierry.position += Vector3.forward * tempSpeedX;
        }
        public void down()
        {
            tempSpeedX += acceleration;
            tempSpeedX = Mathf.Clamp(tempSpeedX, 0, speedMax);
            thierry.position += Vector3.back * tempSpeedX;
        }
        public void left()
        {
            tempSpeedX = Mathf.Clamp(tempSpeedX, speedMax, 0);
            thierry.position += Vector3.left * tempSpeedX;
        }
        public void right()
        {
            tempSpeedX += acceleration;
            tempSpeedX = Mathf.Clamp(tempSpeedX, 0, speedMax);
            thierry.position += Vector3.right * tempSpeedX;
        }
    }
}
