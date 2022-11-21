using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Lancer : MonoBehaviour
{
    public GameObject boule_de_neige;
    public Collider collid;
    public Color[] colors;
    bool collide;
    public Transform boule;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        collide = false;
    }


    private void OnCollisionEnter(Collision other)
    {
        
        print("COLISION");
        if (other.gameObject.CompareTag("Boule_neige"))
        {
            Destroy(other.gameObject);
            collide = true;
            GetComponent<Renderer>().material.color = colors[0];
        }

        if (collide == true)
        {
            var justSpawnedBouleDeNeige = Instantiate(boule, new Vector3(-6.15f, 3.94f, -0.97f), Quaternion.Euler(0, 0, 0));
        }

    }
}
