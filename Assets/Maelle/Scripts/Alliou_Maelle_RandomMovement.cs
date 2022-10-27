using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alliou_Maelle_RandomMovement : MonoBehaviour
{
    public float speed = 0.1f;
    public Vector3 vel;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        vel = Random.insideUnitSphere * speed;
        vel.y = 0.1f;
        transform.Translate(vel * Time.deltaTime);
    }
}
