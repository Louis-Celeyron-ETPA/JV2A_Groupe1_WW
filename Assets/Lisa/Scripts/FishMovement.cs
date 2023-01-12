using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class FishMovement : MonoBehaviour
{

    float velocity = 0;


    public float ySpeed;
    public float yTarget;
    // Start is called before the first frame update
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
    }

    private void OnCollisionEnter(Collision collision)
    {

    }
        
}
