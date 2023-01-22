using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{
    public class BallCollider : MonoBehaviour
    {
        // Start is called before the first frame update
        public Rigidbody2D rd;
        public float ejectingForce = 1f;
        public bool isEjected = false;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnCollisionEnter2D(Collision2D collision)
        {
            BallMovements MovementsColliding = collision.gameObject.GetComponent<BallMovements>();
            if (MovementsColliding != null)
            {
                if (!MovementsColliding.touchedGround)
                {
                    rd.AddForce(new Vector3(1f,0.9f,0f) * ejectingForce);
                    isEjected = true;

                }
            }

        }
    }
}

