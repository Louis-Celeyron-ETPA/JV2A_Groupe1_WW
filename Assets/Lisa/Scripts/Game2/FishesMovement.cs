using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishesMovement : MonoBehaviour
{
    public float timeToChange { get { return (Random.Range(1f,3f)); } }
    private float time = 0f;

    public float velocity = 6f;

    private bool moveRight { get { return (Random.value > 0.5f); } }
    private float sign;

    // Start is called before the first frame update
    void Start()
    {
        velocity = Random.Range(velocity - 3, velocity + 3);

        if (moveRight)
        {
            sign = 1;
        }
        else
        {
            sign = -1;
        }

    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector2(transform.position.x + (velocity*sign) * Time.deltaTime, transform.position.y);

        if (time > timeToChange)
        {
            sign = -sign;
            time = 0;
        }

        time += Time.deltaTime;
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Hook")
        {
            Destroy(this.gameObject);
        }
    }
}
