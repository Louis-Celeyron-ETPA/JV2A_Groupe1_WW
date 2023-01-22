using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lisa_HookMovement : MonoBehaviour
{
    public float speedHook = 0.05f;

    public float score = 0;

    public Lisa_FishSpawner fishSpawner;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Z) == true)
        {
            if (transform.position.y < 3)
                transform.localPosition += transform.up * speedHook;
        }
        if (Input.GetKey(KeyCode.S) == true)
        {
            if (transform.position.y > -25)
                transform.localPosition += transform.up * -speedHook;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Fish")
        {
            score += 1;
            TestVictory();
        }
    }

    private void TestVictory()
    {
        float value = fishSpawner.GetFishNumber();
        if (score == value)
        {
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
