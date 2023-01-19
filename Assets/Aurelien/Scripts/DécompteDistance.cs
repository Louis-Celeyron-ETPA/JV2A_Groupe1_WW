using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Aurelien
{
    public class DecompteDistance : MonoBehaviour
    {

        
        public TextMeshProUGUI NombreDistanceParcourue;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            NombreDistanceParcourue.text = "DistanceParcourue";
        }
        
    }
}