using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Alban
{
    public class Timer : MonoBehaviour
    {
        public float timeRemaining = 15;
        public bool timeIsRunning = false;
        public TextMesh timeText;

        private void Start()
        {
            timeIsRunning = true;
        }

        void Update()
        {

            var other = FindObjectOfType<Requins>();

            if (timeIsRunning == true)
            {
                if (timeRemaining > 0)
                {
                    timeRemaining -= Time.deltaTime;
                }

                else if (timeRemaining <= 0)
                {
                    Debug.Log("Ok !");
                    timeRemaining = 0;
                    timeIsRunning = false;
                }

                else if (timeRemaining <= 0 && other.tag == "Player")
                {
                    Debug.LogError("PARFAIT !");
                    timeRemaining = 0;
                    timeIsRunning = false;
                }
            }

            DisplayTime(timeRemaining);
        }
        void DisplayTime(float timeToDisplay)
        {
            var other = FindObjectOfType<Requins>();
            //timeToDisplay += 1;
            if (timeRemaining >= 0 && timeIsRunning == true)
            {
                float seconds = Mathf.FloorToInt(timeToDisplay % 60);
                timeText.text = string.Format("{0:00}", seconds);
            }

            else if (timeRemaining <= 0 && timeIsRunning == false)
            {
                timeText.text = "Bien !";
            }

            else if (timeRemaining <= 0 && other.tag == "Player" && timeIsRunning == false)
            {
                timeText.text = "PARFAIT !";
            }
        }
    }
}