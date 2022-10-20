using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Hugo
{
    public class Trajectoire : MonoBehaviour
    {
        public Transform thierry;
        public float speedMax = 0.1f;
        public float acceleration = 0.1f;
        public float tempSpeedX = 0;
        public string direction = "";
        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            avancer(thierry);

        }

        public void avancer(Transform thierry)
        {

            if (direction == "haut")
            {
                tempSpeedX += acceleration;
                tempSpeedX = Mathf.Clamp(tempSpeedX, 0, speedMax);
                thierry.position += thierry.forward * tempSpeedX;
            }
            else
            {
                tempSpeedX += acceleration;
                tempSpeedX = Mathf.Clamp(tempSpeedX, 0, speedMax);
                thierry.position -= thierry.forward * tempSpeedX;
            }


        }


        private void OnTriggerEnter(Collider other)
        {
            Joueur objetQuiMeTraverse = other.GetComponent<Joueur>();
            if (objetQuiMeTraverse != null)
            {
                objetQuiMeTraverse.transform.position = new Vector3(41, 12, -6);
            }
        }
    }

}

