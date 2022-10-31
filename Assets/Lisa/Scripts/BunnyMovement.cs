using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BunnyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform move;

    float speed = 0.2f;

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
    }
}
