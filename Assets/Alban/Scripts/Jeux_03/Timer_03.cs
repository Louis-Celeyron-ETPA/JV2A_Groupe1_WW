using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


namespace Alban
{

    public class Timer_03 : MonoBehaviour
    {

        public float timeRemaining = 5;
        public bool timeIsRunning = false;
        public TextMeshProUGUI timeText;

        private void Start()
        {
            timeIsRunning = true;
        }
        void Update()
        {
            var life = FindObjectOfType<Life>().chances;

            if (timeIsRunning == true  && timeRemaining > 0)
            { 
            timeRemaining -= Time.deltaTime;
            }

            if (timeIsRunning == true && timeRemaining <= 0 && (life == 3))
            {
                timeIsRunning = false;
                timeRemaining = 0;
                Debug.LogError("PARFAIT !");
            }

            else if (timeIsRunning == true && timeRemaining <= 0 && (life == 2 || life == 1))
            {
                timeIsRunning = false;
                timeRemaining = 0;
                Debug.LogError("OK !");
            }

            else if (timeIsRunning == true && (life == 0))
            {
                timeIsRunning = false;
                timeRemaining = 0;
                Debug.LogError("Défaite !");
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