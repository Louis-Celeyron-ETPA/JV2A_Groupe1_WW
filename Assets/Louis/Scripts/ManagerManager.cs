using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerManager : MonoBehaviour
{
    [Header("Manager")]
    public Difficulty dificultyManager;
    public MySceneManager sceneManager;

    private static ManagerManager instance;
    public static ManagerManager Instance
    {
        get
        {
            if(instance == null)
            {
                var newManager = new GameObject();
                var m = newManager.AddComponent<ManagerManager>();
                m.dificultyManager = newManager.AddComponent<Difficulty>();
                m.sceneManager = newManager.AddComponent<MySceneManager>();

                return m;
            }
            else
            {
                return instance;
            }
        }
        set
        {
            instance = value;
        }
    }
    public static Difficulty DifficultyManager => Instance.dificultyManager;
    public static MySceneManager SceneManager => Instance.sceneManager;


    private void Awake()
    {
        Debug.LogError("HAHA");

        if(ManagerManager.instance != null)
        {
            return;
        }
        else
        {
            ManagerManager.instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    
    
}
