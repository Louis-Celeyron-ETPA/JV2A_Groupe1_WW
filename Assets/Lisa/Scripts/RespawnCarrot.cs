using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnCarrot : MonoBehaviour
{
    public RecupCarrot carrotePrefab;
    public Transform[] spawnPoint;
    public float delay = 1;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        timer = delay;
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer - Time.deltaTime;
        if(timer<=0)
        {
            Instantiate(carrotePrefab, spawnPoint[Random.Range(0,spawnPoint.Length)]);
            timer = delay;
        }
    }
}
