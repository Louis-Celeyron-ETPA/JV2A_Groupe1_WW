using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Orion
{
    public class BallMovements : MonoBehaviour
    {
        public Rigidbody2D rd;

        public bool isThrown = false;

        public float throwingForce = 100f;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Throw()
        {
            isThrown = true;
            rd.bodyType = RigidbodyType2D.Dynamic;
            rd.AddForce(transform.right * throwingForce);
        }
    }
}

