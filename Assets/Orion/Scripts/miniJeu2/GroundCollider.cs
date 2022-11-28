using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{
    public class GroundCollider : MonoBehaviour
    {
        // Start is called before the first frame update
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
                MovementsColliding.touchedGround = true;
            }

        }
    }
}

