using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alban
{
    public class Curseur : MonoBehaviour
    {
        public KeyCode myKey;
        public Transform Viseur;
        public float speedMax = 0.08f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.Z) == true)
            {
                Viseur.position += Viseur.forward * speedMax;
            }

            if (Input.GetKey(KeyCode.Q) == true)
            {
                Viseur.position += Viseur.right * -1 * speedMax;
            }

            if (Input.GetKey(KeyCode.S) == true)
            {
                Viseur.position += Viseur.forward * -1 * speedMax;
            }

            if (Input.GetKey(KeyCode.D) == true)
            {
                Viseur.position += Viseur.right * speedMax;
            }
        }
    }
}
