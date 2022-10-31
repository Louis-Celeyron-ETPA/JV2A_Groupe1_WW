using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class catapulte : MonoBehaviour
{
    public float speedMax = 1000f;
    public KeyCode myKey;
    public Transform thierry;
    public Rigidbody rgbd;
    public bool IsFired = false;
    public float power = 2000000000, powerMax=2000000000;

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = Vector3.down * 9.81f * 10;
        SceneManager.sceneUnloaded += ResetGravity;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Space) == true&& IsFired == false)
        {
            rgbd.useGravity = true;
            rgbd.AddForce(transform.forward*power);
            IsFired = true;
        }

    }

    private void ResetGravity(Scene s)
    {
        Physics.gravity = Vector3.down * 9.81f;
    }
   
}
