using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aurelien
{
    public class Rotation : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.eulerAngles += transform.up * 0.8f;
        }
    }
}