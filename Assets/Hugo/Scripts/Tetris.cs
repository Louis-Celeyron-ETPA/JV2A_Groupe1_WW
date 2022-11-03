using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetris : MonoBehaviour
{
    public KeyCode myKey;
    public Transform thierry;
    public float speedMax = 0.3f;
    public float acceleration = 0.1f;
    public float tempSpeedX = 0;
    public float rotationSpeed = 1;
    public bool canMove = false;

    public List<GameObject> cubeSelect = new List<GameObject>();
    int i;
    public bool victoire = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (i < cubeSelect.Count)
        {
            if (Input.GetKey(KeyCode.D) == true)
            {
                tempSpeedX += acceleration;
                tempSpeedX = Mathf.Clamp(tempSpeedX, 0, speedMax);
                cubeSelect[i].transform.position += Vector3.right * tempSpeedX;
            }

            if (Input.GetKey(KeyCode.Q) == true)
            {
                tempSpeedX += acceleration;
                tempSpeedX = Mathf.Clamp(tempSpeedX, speedMax, 0);
                cubeSelect[i].transform.position += Vector3.left * tempSpeedX;
            }

            if (cubeSelect[i].transform.position.y < -4)
            {
                i++;
                actionSuivante();
            }
        }
    }


    private void actionSuivante()
    {
        if (i < cubeSelect.Count)
        {
            cubeSelect[i].transform.position = new Vector3(1, 21, -4);


        }
    }
}
