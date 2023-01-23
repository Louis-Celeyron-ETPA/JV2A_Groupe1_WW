using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{
    public class EnemyConstraints : MonoBehaviour
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
            EnemyMovements enemyColliding = collision.gameObject.GetComponent<EnemyMovements>();
            if (enemyColliding != null)
            {
                enemyColliding.currentEnemySpeed = enemyColliding.baseEnemySpeed * enemyColliding.cooldownSpeed;
                enemyColliding.ChangeCooldownDirection();
                enemyColliding.ChangeFocusDirection();
            }
        }
    }
}

