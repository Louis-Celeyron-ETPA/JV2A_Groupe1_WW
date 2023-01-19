using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Hugo
{
    public class Trie : MonoBehaviour
    {
        public KeyCode myKey;
        public Transform thierry;
        public string couleur;
        public bool verifCouleur = false;
        //public Selecteur scoreBleu;
        // Start is called before the first frame update
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        public void CheckTrie(SelecteurCube selecteur)
        {
            if (thierry.position.x <= -17 && couleur == "rouge")
            {
                //compt = compt + 1;
                selecteur.scoreRouge = selecteur.scoreRouge + 1;
            }
            if (thierry.position.x >= 20 && couleur == "bleu")
            {
                //compt = compt + 1;
                selecteur.scoreBleu = selecteur.scoreBleu + 1;
            }
        }

    }
}