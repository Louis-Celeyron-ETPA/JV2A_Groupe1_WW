using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MySceneManager : MonoBehaviour
{
    public Dropdown dropdown;
    private int currentIndex;

    // Start is called before the first frame update
    void Start()
    {
      
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
        SceneManager.LoadScene(dropdown.options[currentIndex].text);
    }
}
