using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gabriel
{

    public class Placer_Objet_1 : MonoBehaviour
    {
        public Transform objet_1;
        public Rigidbody rgbd;
        public float speed = 0.001f;
        public bool isCurrent;
        public Placer_Objet_1 next;
        public string tagToCollider;
        public bool victoire;
        // Start is called before the first frame update
        void Start()
        {
            victoire = false;
        }

        // Update is called once per frame
        void Update()
        {

            if (isCurrent)
            {
                if (Input.GetKey(KeyCode.Z) == true)
                {
                    rgbd.MovePosition(objet_1.position + Vector3.up * speed);
                }

                if (Input.GetKey(KeyCode.D) == true)
                {
                    rgbd.MovePosition(objet_1.position + Vector3.right * speed);
                }

                if (Input.GetKey(KeyCode.S) == true)
                {
                    rgbd.MovePosition(objet_1.position + Vector3.down * speed);
                }

                if (Input.GetKey(KeyCode.Q) == true)
                {
                    rgbd.MovePosition(objet_1.position + Vector3.left * speed);
                }
            }
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.transform.tag == tagToCollider)
            {
                next.isCurrent = true;
                isCurrent = false;

                if (next.isCurrent == false)
                {
                    victoire = true;
                }
            }

        }

    }

}
