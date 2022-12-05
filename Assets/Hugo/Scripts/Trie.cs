using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trie : MonoBehaviour
{
    public KeyCode myKey;
    public Transform thierry;
    public string couleur;
    public Selecteur score;
    public bool verifCouleur=false;
    //public Selecteur scoreBleu;
    // Start is called before the first frame update
    void Start()
    {
        score = FindObjectOfType<Selecteur>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.Q) == true)
        {
            thierry.position = new Vector3(28, 1, -1);
            VerifieCouleur();
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            thierry.position = new Vector3(-28, 1, -1);
            VerifieCouleur();
        }
        */

        if (verifCouleur == false)
        {
            if (thierry.position.x <= -17 && couleur == "rouge")
            {
                //compt = compt + 1;
                score.scoreRouge = score.scoreRouge + 1;
                verifCouleur = true;
        }
            if (thierry.position.x >= 20 && couleur == "bleu")
            {
                //compt = compt + 1;
                score.scoreBleu = score.scoreBleu + 1;
                verifCouleur = true;
            }
        }
    }

}
