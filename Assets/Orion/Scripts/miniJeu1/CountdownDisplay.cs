using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{
    public class CountdownDisplay : MonoBehaviour
    {
        public TMPro.TextMeshProUGUI textMesh;
        public Timer myTimer;
        public string displayedText;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            displayedText = (myTimer.gameTime - myTimer.currentTime).ToString("#");
            textMesh.text = displayedText;
        }
    }
}

