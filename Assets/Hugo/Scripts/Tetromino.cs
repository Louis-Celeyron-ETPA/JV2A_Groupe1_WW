using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetromino : MonoBehaviour
{

    public Tetris tetrisManager;
    public bool touche=false;
    public bool tombe = false;
    /*public Transform thierry;
    public float speedMax = 1f;
    public float acceleration = 0.01f;
    public float tempSpeedY = 0;*/
    // Start is called before the first frame update
    void Start()
    {
        /*tempSpeedY += acceleration;
        tempSpeedY = Mathf.Clamp(tempSpeedY,0, speedMax);
        thierry.position += -thierry.forward * tempSpeedY;*/
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "brick" && touche == false)
        {
          touche = true;
          tetrisManager.OnCollisionConsequence();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "out" && tombe == false)
        {
          tetrisManager.nbPieceTombe = tetrisManager.nbPieceTombe + 1;
          Debug.Log(tetrisManager.nbPieceTombe);
          tombe = true;
        }
    }
}
