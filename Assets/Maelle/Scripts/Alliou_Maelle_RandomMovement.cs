using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alliou_Maelle_RandomMovement : MonoBehaviour
{
    public float speed = 0.01f, rayon = 5;
    public Vector3 target;
    // Start is called before the first frame update
    void Start()
    {
        SetNewTarget();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target,speed);
        if(Vector3.Distance(target, transform.position)<=0.5f)
        {
            SetNewTarget();
        }
    }

    public void SetNewTarget()
    {
        var tempTarget = transform.position + Random.onUnitSphere * rayon;
        target = new Vector3(tempTarget.x, transform.position.y, tempTarget.z);

    }
}
