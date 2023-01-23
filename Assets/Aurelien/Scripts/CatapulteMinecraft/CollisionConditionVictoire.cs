using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionConditionVictoire : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.transform.position.z < -6474)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
                Debug.Log("Fail");

            }

            else if (other.transform.position.z < -3397 && other.transform.position.z > -6474)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                Debug.Log("Sucess");
            }

            else
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Perfect);
                Debug.Log("Perfect");

            }
        }
        
    }
}
