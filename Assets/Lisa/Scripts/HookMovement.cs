using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HookMovement : MonoBehaviour
{
    public float speedHook = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Z) == true)
        {
            if (transform.position.y < 3)
                transform.localPosition += transform.up * speedHook;
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            if (transform.position.y > -25)
                transform.localPosition += transform.up * -speedHook;
        }
    }
}
