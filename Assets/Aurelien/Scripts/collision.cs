using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aurelien
{

    public class collision : MonoBehaviour
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
            Destroy(gameObject);
        }
    }

}

