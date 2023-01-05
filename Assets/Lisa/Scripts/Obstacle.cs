using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
   

    public void Move(float speed)
    {
        transform.Translate(Vector3.left * speed);
    }

}
