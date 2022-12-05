using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alban
{
    public class Bouteille : MonoBehaviour
    {

        public Transform bottle;
        public TextMesh bottles;

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
            var scoreKeeper = FindObjectOfType<Decompte_Boutille>();

            if(scoreKeeper !=null)
            {
                scoreKeeper.Truc();
                Destroy(gameObject);
            }
        }
    }
}
