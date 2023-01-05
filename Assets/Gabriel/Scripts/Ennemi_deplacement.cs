using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemi_deplacement : MonoBehaviour
{
    public Rigidbody rgbd;
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rgbd.MovePosition(transform.position + Vector3.down * speed);
    }
}
