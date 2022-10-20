using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Alban
{
    public class Timer : MonoBehaviour
    {
        public float timeRemaining = 10;
        public bool timeIsRunning = false;
        public Text timeText;

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
                    Debug.Log("Victoire !");
                    timeRemaining = 0;
                    timeIsRunning = false;
                }
            }
        }
        void DisplayTime(float timeToDisplay)
        {
            timeToDisplay += 1;
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);
            timeText.text = string.Format("{0:00}", seconds);
            DisplayTime(timeRemaining);
        }
    }
}