using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Aurelien
{

    public class Jauge : MonoBehaviour
    {
        public Transform barre;
        public bool stop;
        public Vector3 top, bot;
        public float pourcentage;
        public float speed =1;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            pourcentage += Time.deltaTime * speed;
            if(pourcentage>=1)
            {
                pourcentage = 0;
            }
            barre.localPosition = Vector3.Lerp(bot, top, pourcentage);
        }
    }

}

