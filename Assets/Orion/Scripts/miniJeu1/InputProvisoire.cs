using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class InputProvisoire : MonoBehaviour
{
    public Orion.Movements myMovements;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            myMovements.Move();
        }
    }
}
