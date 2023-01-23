using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aurelien
{
    public class Lights : MonoBehaviour
    {
        public Transform lumiere;
        public bool dirGauche = false;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (dirGauche == false)
            {
                lumiere.position -= lumiere.right;
                if (transform.position.z < -7755.6)
                {
                    dirGauche = true;
                }
            }
            else
            {
                lumiere.position += lumiere.right;
                
                if (transform.position.z > -7616.2)
                {
                    dirGauche = false;
                }
            }


        }
    }
}

