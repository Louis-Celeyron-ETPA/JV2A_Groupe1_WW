using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aurelien
{
    public class animaux : MonoBehaviour
    {
        public Transform animal;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            animal.position -= animal.right;
        }
    }
}
