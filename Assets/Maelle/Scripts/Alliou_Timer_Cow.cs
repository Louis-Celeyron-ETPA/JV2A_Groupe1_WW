using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Alliou_Timer_Cow : MonoBehaviour
{
    public float timeT = 20;
    public bool timeActive = false;
    public TextMeshProUGUI displayText;

    // Start is called before the first frame update
    private void Start()
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

        DisplayTime(timeT);
    }
    void DisplayTime(float timeToDisplay)
    {
        //timeToDisplay += 1;
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        displayText.text = string.Format("{0:00}", seconds);
    }
}
