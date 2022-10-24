using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{
    public class ColliderEnemy : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void OnTriggerEnter2D(Collider2D other)
        {
            Movements MovementsColliding = other.GetComponent<Movements>();
            if (MovementsColliding != null)
            {
                MovementsColliding.isDeflated = true;
            }
        }


    }
}
