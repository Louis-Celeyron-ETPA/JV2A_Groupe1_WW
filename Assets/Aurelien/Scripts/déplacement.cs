using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aurelien
{

    public class déplacement : MonoBehaviour
    {
        public KeyCode myKey;
        public Transform thierry;
        public Transform Mélanie;
        public Rigidbody thierryRigidbody;
        public float speedMax = 1000f;
        public Vector3 direction;
        // Start is called before the first frame update
        void Start()
        {

        }

        private void FixedUpdate()
        {
            thierryRigidbody.velocity = direction.normalized * speedMax;

        }
        // Update is called once per frame
        void Update()
        {
            direction = Vector3.zero;
            if (Input.GetKey(KeyCode.Z) == true)
            {
                direction.z = 1;
            }

            if (Input.GetKey(KeyCode.Q) == true)
            {

                direction.x = -1;
            }

            if (Input.GetKey(KeyCode.S) == true)
            {
                direction.z = -1;

            }

            if (Input.GetKey(KeyCode.D) == true)
            {
                direction.x = 1;

            }
        }
    }

}

