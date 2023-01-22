using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{
    public class TestInput : MonoBehaviour
    {
        // Start is called before the first frame update

        public ButtonSelection buttonSelection;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                buttonSelection.ClickButton();
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                buttonSelection.SelectRight();
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                buttonSelection.SelectLeft();
            }


        }
    }
}

