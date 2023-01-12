using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aurelien
{
    public class pieces : MonoBehaviour
    {

        public Transform piece;
        public TextMesh Pieces;

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
            var scoreKeeper = FindObjectOfType<DecomptePiece>();

            if (scoreKeeper != null)
            {
                scoreKeeper.Truc();
                Destroy(gameObject);
            }
        }
    }
}
