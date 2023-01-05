using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Alliou_Timer_Scene_One : MonoBehaviour
{
    public class Timer : MonoBehaviour
    {
        public float timeT = 0;
        public bool timeActive = false;
        public Text displayText;
        public object timeText;

        // Start is called before the first frame update
        void Start()
        {
            timeActive = true;
        }

        // Update is called once per frame
        void Update()
        {
            if (timeActive == true)
            {
                if (timeT > 0)
                {
                    timeT -= Time.deltaTime;
                }
            }
        }
        void DisplayTime(float timeToDisplay)
        {
            //timeToDisplay += 1;
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);
            timeText = string.Format("{0:00}", seconds);
        }
    }
}  