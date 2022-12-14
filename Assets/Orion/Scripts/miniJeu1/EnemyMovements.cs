using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Orion
{
    public class EnemyMovements : MonoBehaviour
    {
        public Transform myTransform;
        public Transform balloonTransform;
        public Vector3 direction;

        public float currentTime = 0f;
        public float timeMax = 2f;
        public float baseEnemySpeed = 2f;
        public float currentEnemySpeed = 2f;
        public float cooldownTime = 1f;
        public float cooldownSpeed = 1f;

        public bool cooldown = false;

        // Start is called before the first frame update
        void Start()
        {
            direction = balloonTransform.position - myTransform.position;
            direction = direction.normalized;
        }

        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime;

            if (cooldown)
            {

                currentEnemySpeed = baseEnemySpeed * cooldownSpeed; 

                if (currentTime >= cooldownTime)
                {
                    cooldown = false;
                    currentTime = 0f;
                }
            }
            else
            {
                currentEnemySpeed = baseEnemySpeed;

                if (currentTime >= timeMax)
                {
                    direction = balloonTransform.position - myTransform.position;
                    direction = direction.normalized;
                    cooldown = true;
                    currentTime = 0f;
                }
            }

            myTransform.position += direction * currentEnemySpeed;

        }
    }
}

