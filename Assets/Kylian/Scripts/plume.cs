using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plume : MonoBehaviour
{
    public Transform vole;
    public KeyCode mykey;

    public float speedMax = 0.01f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) == true)
        {
            transform.Translate(0.01f, 0, 0);
        }

        if (Input.GetKey(KeyCode.Q) == true)
        {
            transform.Translate(-0.01f, 0, 0);
        }

        transform.Translate(0, 0, -0.3f * Time.deltaTime * 3);
    }
}
