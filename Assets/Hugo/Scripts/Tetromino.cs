using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetromino : MonoBehaviour
{

    public Tetris tetrisManager;
    public bool touche=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "brick")
        {
            if (touche == false)
            {
                touche = true;
                tetrisManager.OnCollisionConsequence();
            }
            
        }
    }
}
