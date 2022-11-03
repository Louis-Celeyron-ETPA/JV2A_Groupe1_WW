using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Placer_Objet_1 : MonoBehaviour
{
    public Transform objet_1;
    public Rigidbody rgbd;
    public float speed = 0.001f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Z) == true)
        {
            rgbd.MovePosition( objet_1.position + Vector3.up * speed);
            //thierry.position = thierry.position + new Vector3(0,0,10) = la même chose
        }

        if (Input.GetKey(KeyCode.D) == true)
        {
            rgbd.MovePosition(objet_1.position + Vector3.right * speed);
        }

        if (Input.GetKey(KeyCode.S) == true)
        {
            rgbd.MovePosition(objet_1.position + Vector3.down * speed);
        }

        if (Input.GetKey(KeyCode.Q) == true)
        {
            rgbd.MovePosition(objet_1.position + Vector3.left * speed);
        }
    }
}
