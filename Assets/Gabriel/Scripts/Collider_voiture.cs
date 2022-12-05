using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_voiture : MonoBehaviour
{
    // Start is called before the first frame update

    // Update is called once per frame
    public GameObject bagnole;
    public Collider collid;
    bool collide;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        collide = false;
    }

    private void OnTriggerEnter(Collider other)
    {

        print("COLISION");
        if (other.gameObject.CompareTag("Bagnole"))
        {
            collide = true;
        }

    }
}

