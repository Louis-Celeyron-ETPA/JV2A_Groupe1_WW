using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sauteur : MonoBehaviour
{
    public KeyCode myKey;
    public Transform sauteur;
    public Vector3 initialPos;

    public float speedMax = 0.1f;
    public float acceleration = 0.1f;
    public float tempSpeedX = 0;

    // Start is called before the first frame update
    void Start()
    {
        initialPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) == true) ;
        {
            tempSpeedX += acceleration;
        }
        tempSpeedX = Mathf.Clamp(tempSpeedX, 0, speedMax);

    }
}
