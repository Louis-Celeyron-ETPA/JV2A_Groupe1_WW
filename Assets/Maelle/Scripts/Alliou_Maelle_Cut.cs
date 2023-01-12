using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alliou_Maelle_Cut : MonoBehaviour
{
    public KeyCode myKey;
    public Vector3 positioninitiale;
    public Transform legume;
    public float right = 500;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) == true)
        {
            legume.position = legume.position + Vector3.right;
        }
    }
}
