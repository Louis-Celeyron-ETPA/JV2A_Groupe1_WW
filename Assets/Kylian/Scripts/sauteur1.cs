using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sauteur1 : MonoBehaviour
{
    public Transform sauter;
    public KeyCode myKey;

    public float speedMax = 0.01f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) == true)
        {
            transform.Translate(0, 0.01f, 0);
        }
    }
}
