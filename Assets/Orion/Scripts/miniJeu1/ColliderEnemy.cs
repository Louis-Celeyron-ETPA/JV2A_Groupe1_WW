using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{
    public class ColliderEnemy : MonoBehaviour
    {
        public SpriteRenderer spriteRenderer;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(transform.position.x <= 0f)
            {
                spriteRenderer.flipX = true;
            }
            else
            {
                spriteRenderer.flipX = false;
            }
        }

        public void OnCollisionEnter2D(Collision2D other)
        {
            Movements MovementsColliding = other.gameObject.GetComponent<Movements>();
            if (MovementsColliding != null)
            {
                MovementsColliding.isDeflated = true;
            }
        }


    }
}
