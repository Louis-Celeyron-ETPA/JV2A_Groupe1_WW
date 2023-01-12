using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


namespace Hugo
{
    public class SelecteurCube : MonoBehaviour
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

        private bool doOnce = false;
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
            else if (i >= cubeSelect.Count && victoire == false)
            {
                textRouge.text = scoreRouge.ToString();
                textBleu.text = scoreBleu.ToString();
                victoire = true;
                if (scoreBleu == 4 && scoreRouge == 4)
                {
                    textResultat.text = "Victoire parfaite";
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Perfect);
                }
                else if (scoreBleu >= 2 && scoreRouge >= 2)
                {
                    textResultat.text = "Victoire";
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                }
                else
                {
                    textResultat.text = "Défaite";
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
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

        public void left()
        {
            if(!doOnce)
            {
                doOnce = true;
                cubeSelect[i].transform.position = new Vector3(-22, -1, -1);
                i++;
                actionCube();
            }
        }

        public void right()
        {
            if(!doOnce)
            {
                doOnce = true;
                cubeSelect[i].transform.position = new Vector3(28, 1, -1);
                i++;
                actionCube();
            }
        }

        public void ResetDoOnce()
        {
            doOnce = false;
        }

        //private void VerifCouleur()
    }
}
