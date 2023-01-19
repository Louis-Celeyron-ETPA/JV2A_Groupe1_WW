using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voiture_deplacement : MonoBehaviour
{
    public Transform voiture;
    public Rigidbody rgbd;
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void MoveRight()
    {
        rgbd.MovePosition(voiture.position + Vector3.right * speed);
    }

    public void MoveLeft()
    {
        rgbd.MovePosition(voiture.position + Vector3.left * speed);
    }
}
