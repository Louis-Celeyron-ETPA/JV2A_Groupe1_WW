using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestouilleLaGrenouille : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
        ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Perfect);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
