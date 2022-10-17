using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    public List<Scene> scenes;
    public Dropdown dropdown;
    private int currentIndex;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SceneManager.sceneCountInBuildSettings);
        for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            scenes.Add(SceneManager.GetSceneByBuildIndex(i));
        }
        dropdown.options.Clear();
        foreach (var scene in scenes)
        {
            dropdown.options.Add(new Dropdown.OptionData("Scene Numero " + scene.buildIndex.ToString("00")));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCurrentIndex(int newIndex)
    {
        currentIndex = newIndex;
    }
    public void LoadSceneAtCurrentIndex()
    {
        SceneManager.LoadScene(currentIndex);
    }
}
