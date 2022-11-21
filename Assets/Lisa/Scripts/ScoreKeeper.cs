using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    public int score;
    public Text scoreTextRef;
    public void RaiseScore(int amount)
    {
        score = score + amount;
        scoreTextRef.text = score.ToString("00");
    }
}
