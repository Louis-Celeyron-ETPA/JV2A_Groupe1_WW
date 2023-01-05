using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    
public class GameOverFish : MonoBehaviour

{
    public GameObject GameOverSprite;
    float velocity = 0;

    public float ySpeed;
    public float yTarget;

    void GameOver()
    {
        Destroy(gameObject);
        GameOverSprite.SetActive(true);
    }


    // Start is called before the first fra
    // me update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * velocity;
        velocity -= 0.005f;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            velocity = 0.15f;
        }

        if (transform.position.y < -5)
        {
            GameOver();
        }
    }
}


