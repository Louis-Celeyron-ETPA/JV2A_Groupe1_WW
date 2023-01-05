using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joueur : MonoBehaviour
{
    public KeyCode myKey;
    public Transform thierry;

    public float speedMax = 0.1f;
    public float acceleration = 0.01f;
    public float tempSpeedX = 0;
    public float rotationSpeed = 1;
    public bool canMove = false;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.Z) == true)
        {
            tempSpeedX += acceleration;
            tempSpeedX = Mathf.Clamp(tempSpeedX, 0, speedMax);
            thierry.position += thierry.forward * tempSpeedX;
        }

        if (Input.GetKey(KeyCode.S) == true)
        {
            tempSpeedX += acceleration;
            tempSpeedX = Mathf.Clamp(tempSpeedX, 0, speedMax);
            thierry.position -= thierry.forward * tempSpeedX;
        }

        if (Input.GetKey(KeyCode.Z) == false && Input.GetKey(KeyCode.S) == false && Input.GetKey(KeyCode.Q) == false && Input.GetKey(KeyCode.D) == false && tempSpeedX != 0)
        {
            tempSpeedX -= acceleration;

        }

        if (Input.GetKey(KeyCode.Q) == true)
        {
            tempSpeedX = Mathf.Clamp(tempSpeedX, speedMax, 0);
            thierry.position -= Vector3.right *tempSpeedX;
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            tempSpeedX = Mathf.Clamp(tempSpeedX, -speedMax, 0);
            thierry.position += Vector3.left * tempSpeedX;
        }*/


        if (Input.GetKey(KeyCode.Z) == true)
        {
            tempSpeedX += acceleration;
            tempSpeedX = Mathf.Clamp(tempSpeedX, 0, speedMax);
            thierry.position += Vector3.forward * tempSpeedX;
        }

        if (Input.GetKey(KeyCode.S) == true)
        {
            tempSpeedX += acceleration;
            tempSpeedX = Mathf.Clamp(tempSpeedX, 0, speedMax);
            thierry.position += Vector3.back * tempSpeedX;
        }

        if (Input.GetKey(KeyCode.Q) == true)
        {
            tempSpeedX = Mathf.Clamp(tempSpeedX, speedMax, 0);
            thierry.position += Vector3.left * tempSpeedX;
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            tempSpeedX += acceleration;
            tempSpeedX = Mathf.Clamp(tempSpeedX, 0, speedMax);
            thierry.position += Vector3.right * tempSpeedX;
        }
    }
}
