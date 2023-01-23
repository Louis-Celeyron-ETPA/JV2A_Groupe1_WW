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
        public Vector2 cooldownDirection;

        public float currentTime = 0f;
        public float timeMax = 2f;
        public float baseEnemySpeed = 2f;
        public float currentEnemySpeed = 2f;
        public float cooldownTime = 1f;
        public float cooldownSpeed = 1f;
        public float radius = 20f;

        public bool cooldown = true;

        private Vector2 _initialPosition;

        // Start is called before the first frame update
        void Start()
        {
            _initialPosition = myTransform.position;
            ChangeCooldownDirection();
            ChangeFocusDirection();

        }

        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime;

            if (cooldown)
            {

                currentEnemySpeed = baseEnemySpeed * cooldownSpeed;

                myTransform.position = Vector2.MoveTowards(myTransform.position, cooldownDirection, currentEnemySpeed * Time.deltaTime);

                if (Vector3.Distance(cooldownDirection, myTransform.position) <= 0.1f)
                {
                    ChangeCooldownDirection();
                }

                if (currentTime >= cooldownTime)
                {
                    direction = balloonTransform.position - myTransform.position;
                    direction = direction.normalized;
                    cooldown = false;
                    currentTime = 0f;
                }
            }
            else
            {
                currentEnemySpeed = baseEnemySpeed;

                myTransform.position += currentEnemySpeed * Time.deltaTime * direction;

                if (currentTime >= timeMax)
                {
                    _initialPosition = myTransform.position;
                    ChangeCooldownDirection();
                    ChangeFocusDirection();
                    cooldown = true;
                    currentTime = 0f;
                }
            }
        }

        public void ChangeCooldownDirection()
        {
            cooldownDirection = _initialPosition + Random.insideUnitCircle * radius;
        }

        public void ChangeFocusDirection()
        {
            direction = balloonTransform.position - myTransform.position;
            direction = direction.normalized;
        }
    }
}

