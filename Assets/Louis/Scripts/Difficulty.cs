using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour
{
    public static Difficulty Instance;
    public int maxDifficulty = 9;
    public int minDifficulty = 0;
    private void Awake()
    {
        if(Difficulty.Instance != null)
        {
            return;
        }
        Instance = this;
        DontDestroyOnLoad(this);
    }

    private static Difficulty GetDifficultyClass()
    {
        if(Difficulty.Instance == null)
        {
            return new Difficulty();
        }
        else
        {
            return Difficulty.Instance;
        }
    }

    private int currentDifficulty = 1;
    public void RiseDifficulty()
    {
        currentDifficulty++;
        currentDifficulty = Mathf.Clamp(currentDifficulty, minDifficulty, maxDifficulty);
    }
    public void DowngradeDifficulty()
    {
        currentDifficulty--;
        currentDifficulty = Mathf.Clamp(currentDifficulty, minDifficulty, maxDifficulty);
    }
    public int GetDifficulty()
    {
        return currentDifficulty;
    }
}
