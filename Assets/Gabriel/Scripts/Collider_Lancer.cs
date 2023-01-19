using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Gabriel
{

    public class Collider_Lancer : MonoBehaviour
    {
        public GameObject boule_de_neige;
        public Collider collid;
        public Color[] colors;
        bool collide;
        public Transform boule;
        public int monScore = 0;

        public TextMeshProUGUI monTexte;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            collide = false;

            monTexte.text = "Score : " + monScore.ToString();
        }

        private void OnTriggerEnter(Collider other)
        {

            var lancer = other.transform.gameObject.GetComponent<Gabriel.Lancer>();
            if (lancer != null)
            {
                if (lancer.toucher == false)
                {
                    monScore++;
                    lancer.toucher = true;
                }
            }
            print("COLISION");
            if (other.gameObject.CompareTag("Boule_neige"))
            {
                Destroy(other.gameObject);
                collide = true;
                GetComponent<Renderer>().material.color = colors[0];
            }

            if (collide == true)
            {
                var justSpawnedBouleDeNeige = Instantiate(boule, new Vector3(-6.15f, 3.94f, -0.97f), Quaternion.Euler(0, 0, 0));
            }

        }

    }

}
