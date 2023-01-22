using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lisa_BunnyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform move;

    float speed = 0.25f;

    public float time = 0f;
    public float MaxTime = 20f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) == true)
        {
            //move.position += move.right;
            transform.localPosition += transform.right * speed;
        }
        if (Input.GetKey(KeyCode.Q) == true)
        {
            //move.position += move.forward;
            transform.localPosition += transform.right * -speed;
        }

        time += Time.deltaTime;

        if (time > MaxTime)
        {
            //ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
