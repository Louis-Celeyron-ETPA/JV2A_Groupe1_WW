using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class haie : MonoBehaviour
{
    public Transform haiees;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * 3);
    }

    public void OnTriggerEnter(Collider other)
    {
        
    }
}
