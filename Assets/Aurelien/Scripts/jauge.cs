using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aurelien
{

    public class jauge : MonoBehaviour
    {
        public Transform barre;
        public bool stop;
        
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (stop == false)
            {
                barre.position -= barre.up;
            }

            if(stop == true)
            {
                barre.position += barre.up;
            }

            if(barre.position.y <= 24)
            {
                stop = true;
            }
        }
    }

}

