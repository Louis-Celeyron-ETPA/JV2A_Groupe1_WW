using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Selecteur : MonoBehaviour
{
    public List<Trie> cubeSelect = new List<Trie>();
    private Renderer mr;
    int i;
    public TextMeshPro textRouge;
    public TextMeshPro textBleu;
    public TextMeshPro textResultat;
    public int scoreRouge;
    public int scoreBleu;
    public bool victoire = false;
    // Start is called before the first frame update
    void Start()
    {
        scoreRouge = 0;
        scoreBleu = 0;
        i = 0;
        actionCube();
    }

    // Update is called once per frame
    void Update()
    {
        if (i < cubeSelect.Count)
        {
            if (Input.GetKeyDown(KeyCode.D) == true)
            {
                cubeSelect[i].transform.position = new Vector3(28, 1, -1);
                i++;
                actionCube();
            }

            if (Input.GetKeyDown(KeyCode.Q) == true)
            {
                cubeSelect[i].transform.position = new Vector3(-22, -1, -1);
                i++;
                actionCube();
            }

            //VerifieCouleur();
        }
        else if (i>= cubeSelect.Count && victoire==false)
        {
            textRouge.text = scoreRouge.ToString();
            textBleu.text = scoreBleu.ToString();
            victoire = true;
            if(scoreBleu==4 && scoreRouge == 4)
            {
                textResultat.text = "Victoire parfaite";
            }else if (scoreBleu >=2 && scoreRouge >= 2)
            {
                textResultat.text = "Victoire";
            }
            else{
                textResultat.text = "Défaite";
            }
            

        }
    }

    private void actionCube()
    {
        if (i < cubeSelect.Count)
        {
            mr = cubeSelect[i].GetComponent<Renderer>();
            //mr.material.color = new Color(0f, 0f, 1f, 1f);
            if (cubeSelect[i].couleur == "bleu")
            {
                mr.material.color = new Color(0f, 0f, 1f, 1f);
            }
            if (cubeSelect[i].couleur == "rouge")
            {
                mr.material.color = new Color(1f, 0f, 0f, 0f);
            }

        }
    }

    //private void VerifCouleur()
}
