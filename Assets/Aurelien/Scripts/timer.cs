using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Aurelien
{
    public class Timer : MonoBehaviour
    {
        public float timeRemaining = 15;
        public bool timeIsRunning = false;
        public TextMeshProUGUI timeText;

        private void Start()
        {
            timeIsRunning = true;
        }

        void Update()
        {

            var pieceRemaining = FindObjectOfType<DecomptePiece>().pieceRemaining;

            if (timeIsRunning == true)
            {
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                }

                else if (timeRemaining <= 0 && pieceRemaining > 5)
                {
                    Debug.LogError("Défaite !");
                    timeRemaining = 0;
                    timeIsRunning = false;
                }

                else if (timeRemaining <= 0 && pieceRemaining <= 5)
                {
                    Debug.LogError("OK !");
                    timeRemaining = 0;
                    timeIsRunning = false;
                }

                //PARFAIT dans le Script "Decompe_Piece"


            }

            DisplayTime(timeRemaining);
        }
        void DisplayTime(float timeToDisplay)
        {
            //timeToDisplay += 1;
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);
            timeText.text = string.Format("{0:00}", seconds);
        }
    }
}
