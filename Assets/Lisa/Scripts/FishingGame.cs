using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishingGame : MonoBehaviour
{

    float speedC = 10f;
    bool moveRight = true;

    /*public float time;
    public float duration = 2f;
    public GameObject positionA;
    public GameObject positionB;

    public bool hasArrivedB = false;
    public bool hasArrivedA = true;*/

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 56f)
            moveRight = false;
        if (transform.position.x < -56f)
            moveRight = true;

        /*time += time.deltaTime;
        float percentageComplete = time / duration;

        if (chara_Move == positionB)
        {
            hasArrivedB = true;
            hasArrivedA = false;
            time = 0;
        }
        else if (chara_Move == positionA)
        {
            hasArrivedB = false;
            hasArrivedA = true;
            time = 0;
        }

        if (hasArrivedA == true)
        {
            chara_Move.position = Vector3.Lerp(positionA.position, positionB.position, percentageComplete);
        }
        else if (hasArrivedB == true)
        {
            chara_Move.position = Vector3.Lerp(positionB, positionA, percentageComplete);
        }*/

        if (moveRight)
            transform.position = new Vector2(transform.position.x + speedC * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - speedC * Time.deltaTime, transform.position.y);
    }
}
