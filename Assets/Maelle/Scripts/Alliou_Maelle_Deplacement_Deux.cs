using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alliou_Maelle_Deplacement_Deux: MonoBehaviour
{
    public KeyCode myKey;
    public Vector3 positioninitiale;
    public Transform thierry;
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z) == true)
        {
            thierry.position = thierry.position + Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            thierry.position = thierry.position + Vector3.back;
        }
        if (Input.GetKey(KeyCode.Q) == true)
        {
            thierry.position = thierry.position + Vector3.left;
        }
        if (Input.GetKey(KeyCode.D) == true)
        {
            thierry.position = thierry.position + Vector3.right;
        }
    }
}
