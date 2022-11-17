using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Alban
{
    public class Timer_02 : MonoBehaviour
    {
        public float timeRemaining = 15;
        public bool timeIsRunning = false;
        public TextMeshPro timeText;

        private void Start()
        {
            timeIsRunning = true;
        }

        void Update()
        {
            if (timeIsRunning == true)
            {
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                }

                else if (timeRemaining <= 0)
                {
                    Debug.LogError("Défaite !");
                    timeRemaining = 0;
                    timeIsRunning = false;
                }
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