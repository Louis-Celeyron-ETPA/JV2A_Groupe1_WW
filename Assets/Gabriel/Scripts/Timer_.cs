using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Gabriel
{

    public class Timer_ : MonoBehaviour
    {
        // Start is called before the first frame update
        public float timeRemaining = 20;
        public bool timeIsRunning = false;
        public TextMeshProUGUI timeText;
        private bool Victoire;

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
            }
                DisplayTime(timeRemaining);
        }
        

        void DisplayTime(float timeToDisplay)
        {
            //timeToDisplay += 1;
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);
            timeText.text = string.Format("{0:00}", seconds);

            if (timeRemaining == 0)
            {
                if (Victoire == true)
                {
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                }
                else
                {
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
                }
            }
        }
    }


}
