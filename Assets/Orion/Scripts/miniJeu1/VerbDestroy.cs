using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{
    public class VerbDestroy : MonoBehaviour
    {
        public Timer timer;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if(timer.currentTime>= 1.5f)
            {
                Destroy(this.gameObject);
            }

        }
    }
}

