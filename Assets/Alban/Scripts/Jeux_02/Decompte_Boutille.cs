using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Alban
{
    public class Decompte_Boutille : MonoBehaviour
    {

        public float bottleRemaining = 10;
        public TextMeshProUGUI NombreBouteilleRestante;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            if (bottleRemaining == 0)
            {
                Debug.LogError("PARFAIT !");
            }

            NombreBouteilleRestante.text = "Bouteilles Restantes : " + bottleRemaining;
        }
        public void Truc()
        {
           bottleRemaining -= 1;
        }
    }
}
