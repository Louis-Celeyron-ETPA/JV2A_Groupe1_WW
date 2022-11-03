using System.Collections;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    public  Dropdown dropdown;
    private int currentIndex;
    private List<string> allScenes;
    private int minigamesFinished;


    void Start()
    {
        if(!dropdown)
        {
            return;
        }

        allScenes = dropdown.options.Select(o => o.text).ToList();
    }
    public void SetCurrentIndex(int newIndex)
    {
        currentIndex = newIndex;
    }
    public void LoadSceneAtCurrentIndex()
    {
        SceneManager.LoadScene(dropdown.options[currentIndex].text);
    }
    public void EndOfMinigame(MinigameRating mgRating)
    {
        var tempAddToTime = 0f;
        switch (mgRating)
        {
            case MinigameRating.Fail:
                tempAddToTime = ManagerManager.TimeManager.failTimeAdded;
                break;
            case MinigameRating.Success:
                minigamesFinished++;
                tempAddToTime = ManagerManager.TimeManager.normalTimeAdded;
                break;
            case MinigameRating.Perfect:
                minigamesFinished++;
                tempAddToTime = ManagerManager.TimeManager.perfectTimeAdded;
                break;
            default:
                tempAddToTime = 0;
                break;
        }
        ManagerManager.TimeManager.globalTime += tempAddToTime;

        var nextScene = SceneManager.GetActiveScene().name;
        while(nextScene == SceneManager.GetActiveScene().name)
        {
            nextScene = allScenes[Random.Range(0, allScenes.Count)];
        }

    }
}
