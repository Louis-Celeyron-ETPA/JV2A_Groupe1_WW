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
    private List<string> unloadedScenes;

    void Start()
    {
        if(!dropdown)
        {
            return;
        }

        unloadedScenes = allScenes;
        allScenes = dropdown.options.Select(o => o.text).ToList();
    }
    public void SetCurrentIndex(int newIndex)
    {
        currentIndex = newIndex;
    }
    public void LoadSceneAtCurrentIndex()
    {
        var textAtIndex = dropdown.options[currentIndex].text;
        LoadScene(textAtIndex);        
    }

    public void LoadRandomScene()
    {
        var nextScene = unloadedScenes[Random.Range(0, allScenes.Count)];
        LoadScene(nextScene);
    }
    private void LoadScene (string scene)
    {
        unloadedScenes.Remove(scene);
        if (unloadedScenes.Count <= 1)
        {
            unloadedScenes = allScenes;
        }
        SceneManager.LoadScene(scene);
    }
}
