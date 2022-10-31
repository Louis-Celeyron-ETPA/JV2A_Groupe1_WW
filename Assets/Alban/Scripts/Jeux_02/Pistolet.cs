using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alban {

    public class Pistolet : MonoBehaviour
    {
        public Transform sonViseur;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            transform.LookAt(new Vector3(sonViseur.position.x, sonViseur.position.z));
        }
    }
}
