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
    public string tagToCollider;
    public Rigidbody rgbd;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        collide = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == tagToCollider)
        {
            collide = true;
        }

    }
}

