using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alliou_Maelle_Cut : MonoBehaviour
{
    public KeyCode myKey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z) == true)
        {
            Destroy(gameObject);
        }
    }
}
