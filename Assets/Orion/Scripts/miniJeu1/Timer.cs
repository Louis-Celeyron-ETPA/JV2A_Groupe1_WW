using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{
    public class Timer : MonoBehaviour
    {
        public float currentTime;
        public float gameTime;
        public bool gameFinished;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            currentTime += Time.deltaTime;
            if(currentTime > gameTime)
            {
                gameFinished = true;
            }

        }
    }
}

