using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Lancer : MonoBehaviour
{
    public GameObject boule_de_neige;
    public Collider collid;
    public Color[] colors;
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
        
        print("COLISION");
        if (other.gameObject.CompareTag("Boule_neige"))
        {
            Destroy(other.gameObject);

            GetComponent<Renderer>().material.color = colors[0];
        }

    }
}
