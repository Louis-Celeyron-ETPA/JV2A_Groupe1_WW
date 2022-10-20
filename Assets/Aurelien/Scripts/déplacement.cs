using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class déplacement : MonoBehaviour
{
    public KeyCode myKey;
    public Transform thierry;
    public Transform Mélanie;
    public float speedMax = 1000f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z) == true)
        {
            thierry.position += thierry.forward * speedMax;
        }

        if (Input.GetKey(KeyCode.Q) == true)
        {
            thierry.position += thierry.right * -1 * speedMax;
        }

        if (Input.GetKey(KeyCode.S) == true)
        {
            thierry.position += thierry.forward * -1 * speedMax;
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            thierry.position += thierry.right * speedMax;
        }



    }
}