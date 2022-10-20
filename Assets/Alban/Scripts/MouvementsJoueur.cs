using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Alban
{
    public class MouvementsJoueur : MonoBehaviour
    {
        public KeyCode myKey;
        public Transform Joueur;
        public float speedMax = 0.08f;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.Z) == true)
            {
                Joueur.position += Joueur.forward * speedMax;
            }

            if (Input.GetKey(KeyCode.Q) == true)
            {
                Joueur.position += Joueur.right * -1 * speedMax;
            }

            if (Input.GetKey(KeyCode.S) == true)
            {
                Joueur.position += Joueur.forward * -1 * speedMax;
            }

            if (Input.GetKey(KeyCode.D) == true)
            {
                Joueur.position += Joueur.right * speedMax;
            }
        }
    }
}
