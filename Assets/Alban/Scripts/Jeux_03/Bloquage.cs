using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alban
{
    public class Bloquage : MonoBehaviour
    {

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {

            var timer03 = FindObjectOfType<Timer_03>();

            if (other.tag == "Bad")
            {
                Destroy(other.gameObject);

            }
            if (other.tag == "Good")
            {
                Destroy(other.gameObject);
                timer03.life -= 1;
            }
        }

    }
}
