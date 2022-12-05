using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alban
{
    public class Tir : MonoBehaviour
    {

        public Rigidbody bullet;
        public float fireRate = 1;
        private float nextFire = 0.0f;
        public float speed = 3;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.Space) == true && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Rigidbody instantiatedProjectile = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            Destroy(bullet);
        }
    }
}
