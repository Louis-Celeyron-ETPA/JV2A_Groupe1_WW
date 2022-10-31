using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{
    public class ArmMovements : MonoBehaviour

    {
        public Transform myTransform;

        public float rotateValue = 1f;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            myTransform.Rotate(new Vector3(0, 0, rotateValue));
            if (myTransform.rotation.eulerAngles.z >= 90f)
            {
                rotateValue = rotateValue * -1f;
            }

        }
    }
}

