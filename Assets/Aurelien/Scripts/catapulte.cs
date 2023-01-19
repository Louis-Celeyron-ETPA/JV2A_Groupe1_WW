using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Aurelien
{


    public class Catapulte : MonoBehaviour
    {
        public float speedMax = 1000f;
        public KeyCode myKey;
        public Transform thierry;
        public Rigidbody rgbd;
        public bool IsFired = false;
        public float power = 2000000000, powerMax = 2000000000;
        public Jauge valeurJauge; 

    // Start is called before the first frame update
    void Start()
        {
            Physics.gravity = Vector3.down * 9.81f * 10;
            SceneManager.sceneUnloaded += ResetGravity;
        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetKey(KeyCode.Space) == true && IsFired == false)
            {
                float puissance = valeurJauge.pourcentage; 

                rgbd.useGravity = true;
                rgbd.AddForce(transform.forward * power* puissance);
                IsFired = true;
            }

        }

        private void ResetGravity(Scene s)
        {
            Physics.gravity = Vector3.down * 9.81f;
        }

    }
}
