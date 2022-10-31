using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public float globalTime;
    public float startTimer=300;

    public float perfectTimeAdded = 30, normalTimeAdded=15, failTimeAdded=-15;
    public bool debugTimer = true;

    public GUIStyle style;

    private void Start()
    {
        style.normal.textColor = Color.red;
        globalTime = startTimer;
    }

    private void Update()
    {
        globalTime -= Time.deltaTime;
        if(globalTime <=0)
        {
            Debug.LogWarning("C'est perdu :'(");
        }
    }

    private void OnGUI()
    {
        if(debugTimer)
        {
            GUILayout.Label(globalTime.ToString("00"),style);
        }
    }

}
