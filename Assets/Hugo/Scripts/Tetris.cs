using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetris : MonoBehaviour
{
    public KeyCode myKey;
    public Transform tetrominoSpawn;
    public float speedMax = 0.3f;
    public float acceleration = 0.1f;
    public float tempSpeedX = 0;
    public float rotationSpeed = 1;
    public bool canMove = false;

    public List<Tetromino> cubeSelectPrefab;
    public Tetromino currentTetromino;
    public bool victoire = false;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
        GenerateTetromino();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D) == true)
        {
            tempSpeedX += acceleration;
            tempSpeedX = Mathf.Clamp(tempSpeedX, 0, speedMax);
            currentTetromino.transform.position += Vector3.right * tempSpeedX;
        }

        if (Input.GetKey(KeyCode.Q) == true)
        {
            tempSpeedX += acceleration;
            tempSpeedX = Mathf.Clamp(tempSpeedX, speedMax, 0);
            currentTetromino.transform.position += Vector3.left * tempSpeedX;
        }
        
    }


    private void GenerateTetromino()
    {
        if(index<10)
        {
            currentTetromino = Instantiate(cubeSelectPrefab[Random.Range(0, cubeSelectPrefab.Count)],tetrominoSpawn);
            currentTetromino.tetrisManager = this;
            index++;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "brick")
        {
            OnCollisionConsequence();
        }
    }

    public void OnCollisionConsequence()
    {
        GenerateTetromino();
    }

  
}
