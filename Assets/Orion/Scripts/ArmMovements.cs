using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmMovements : MonoBehaviour

{
    public Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        myTransform.Rotate(new Vector3(0, 0, 90));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
