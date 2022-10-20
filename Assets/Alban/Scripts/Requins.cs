using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Alban{
    public class Requins : MonoBehaviour
    {

        public Transform target;
        float mooveSpeed = 5;
        public Transform myTransform;
        public Rigidbody rgbd;

        // Start is called before the first frame update
        void Start()
        {
            target = GameObject.FindWithTag("Player").transform;
        }

        // Update is called once per frame
        void Update()
        {
            transform.LookAt(new Vector3(target.position.x, transform.position.y, target.position.z));
            rgbd.MovePosition(transform.position + (transform.forward * mooveSpeed * Time.deltaTime));
            //myTransform.Translate(Vector3.forward * mooveSpeed * Time.deltaTime);
        }


        private void OnTriggerEnter(Collider other)
        {
            var timer = other.GetComponent<Timer>();
            if(timer != null)
            {

                float timeRemaining = timer.timeRemaining;

                if (other.tag == "Player" && timeRemaining >= 0)
                {
                    Debug.LogError("T mort");
                }

                else if (other.tag == "Player" && timeRemaining <= 0)
                {
                    Debug.LogError("Parfait !");
                }
            }
        }
    }
}
