using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trie : MonoBehaviour
{
    public KeyCode myKey;
    public Transform thierry;
    public string couleur;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q) == true)
        {
            thierry.position = new Vector3(28, 1, -1);
            VerifieCouleur();
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            thierry.position = new Vector3(-28, 1, -1);
            VerifieCouleur();
        }

           
    }

    private void VerifieCouleur()
    {
        if (thierry.position.x >= -17 && couleur == "rouge")
        {
            //compt = compt + 1;
        }
    }
}
