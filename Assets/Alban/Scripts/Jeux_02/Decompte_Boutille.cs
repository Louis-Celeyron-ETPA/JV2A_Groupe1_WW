using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alban
{
    public class Decompte_Boutille : MonoBehaviour
    {

        public float bottleRemaining = 10;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            var bullet = FindObjectOfType<Tir>();

            if (bullet != null)
            {
                bottleRemaining -= 1;
            }

            if (bottleRemaining == 0)
            {
                Debug.LogError("Victoire !");
            }
            
        }
    }
}
