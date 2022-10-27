using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCarrot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Respawn")
        {
            other.transform.position = new Vector3(other.transform.position.x, 25,other.transform.position.z);
        }
    }
}
