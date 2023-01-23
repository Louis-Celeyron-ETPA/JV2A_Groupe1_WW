using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alban
{

    public class MouvementFood : MonoBehaviour
    {

        public Transform Nourriture;
        public float speedMax = 0.05f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            var timer03 = FindObjectOfType<Timer_JeuxBouche>();

            Nourriture.position += Nourriture.right * speedMax;

            if (Nourriture.position.x >= 5)
            {
                Destroy(gameObject);

                if(tag == "Bad")
                {
                    timer03.life -= 1;
                }
            }
        }
    }
}
