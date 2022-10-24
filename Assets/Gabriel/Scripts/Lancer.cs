using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gabriel
{
    public class Lancer : MonoBehaviour

    {
        public Transform boule_de_neige;
        public float speed = 0.4f;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.Space) == true)
            {
                boule_de_neige.position = boule_de_neige.position + Vector3.right * speed;
            }
        }
    }
}
