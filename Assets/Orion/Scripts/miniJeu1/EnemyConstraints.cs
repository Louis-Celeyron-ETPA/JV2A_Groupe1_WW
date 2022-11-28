using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{
    public class EnemyConstraints : MonoBehaviour
    {
        public Transform myTransform;

        public float minX = -12.7f;
        public float maxX = 11.9f;
        public float maxY = 7.7f;
        public float minY = -2.7f;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (myTransform.position.x <= minX)
            {
                var x = minX + 0.2f;
                var y = myTransform.position.y;
                var z = myTransform.position.z;
                myTransform.position = new Vector3(x, y, z);
            }
            else if (myTransform.position.x >= maxX)
            {
                var x = maxX - 0.2f;
                var y = myTransform.position.y;
                var z = myTransform.position.z;
                myTransform.position = new Vector3(x, y, z);
            }

            if (myTransform.position.y >= maxY)
            {
                var x = myTransform.position.x;
                var y = maxY - 0.2f;
                var z = myTransform.position.z;
                myTransform.position = new Vector3(x, y, z);
            }
            else if (myTransform.position.y <= minY)
            {
                var x = myTransform.position.x;
                var y = minY;
                var z = myTransform.position.z;
                myTransform.position = new Vector3(x, y, z);
            }
        }
    }
}

