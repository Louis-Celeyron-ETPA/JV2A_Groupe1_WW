using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{
    public class CameraFollow : MonoBehaviour
    {
        // Start is called before the first frame update
        public bool condition = false;
        public Transform target;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (condition)
            {
                transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
            }
        }
    }
}

