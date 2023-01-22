using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lisa_CharacterMovement : MonoBehaviour
{

    float speedC = 10f;
    bool moveRight = true;

    void Start()
    {

    }

    void Update()
    {
        if (transform.position.x > 56f)
            moveRight = false;
        if (transform.position.x < -56f)
            moveRight = true;

        if (moveRight)
            transform.position = new Vector2(transform.position.x + speedC * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - speedC * Time.deltaTime, transform.position.y);
    }
}
