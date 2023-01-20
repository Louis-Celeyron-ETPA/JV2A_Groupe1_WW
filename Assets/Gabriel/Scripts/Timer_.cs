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
        public Collider_voiture cV;
        public int whichGameImIn;
        public Collider_Lancer cL;
        public Placer_Objet_1 pO1;

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

            if (whichGameImIn == 0)
            {
                if (seconds < 0)
                {
                    if (cV.monScore > 14)
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Perfect);
                    }
                    else if (cV.monScore < 7)
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
                    }
                    else
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                    }
                }
            }

            else if (whichGameImIn == 1)
            {
                if (seconds < 0)
                {
                    if (cL.monScore > 9)
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Perfect);
                    }
                    else if (cL.monScore < 5)
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
                    }
                    else
                    {
                        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                    }
                }
            }

            else
            {
                if (seconds < 0)
                {
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
                }
                Debug.Log("Prout");
                if (pO1.victoire == true)
                {
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                }
            }
        }
    }


}
