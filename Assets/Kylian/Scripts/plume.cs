using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plume : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-1 * Vector3.forward * Time.deltaTime * 1) ;
    }

    public void OnTriggerEnter(Collider other)
    {

    }
}
