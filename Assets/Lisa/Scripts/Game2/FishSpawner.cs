using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishSpawner : MonoBehaviour
{
    public float nbToSpawn = 6;

    public GameObject prefabFish;

    private float topLimit = 0f;
    private float botLimit = -26f;

    private float rightLimit = 50f;
    private float leftLimit = -50f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < nbToSpawn; i++)
        {
            GameObject truc = Instantiate(prefabFish);
            truc.transform.position = transform.position + new Vector3(Random.Range(leftLimit,rightLimit), Random.Range(botLimit, topLimit), 0);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float GetFishNumber()
    {
        return nbToSpawn;
    }
}
