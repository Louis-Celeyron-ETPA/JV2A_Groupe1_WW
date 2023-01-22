using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class FishMovement : MonoBehaviour
{

    public float velocity = 2f;
    private Rigidbody2D rdb;

    public bool GameOver = false;

    public float time = 0f;
    public float MaxTime = 20f;

    void Start()
    {
        rdb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rdb.velocity = Vector2.up * velocity;
        }

        time += Time.deltaTime;

        if (time > MaxTime)
        {
            //ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameOver = true;
        //ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
        UnityEditor.EditorApplication.isPlaying = false;
    }
        
}
