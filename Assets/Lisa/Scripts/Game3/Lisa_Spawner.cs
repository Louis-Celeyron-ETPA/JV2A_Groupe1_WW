using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lisa_Spawner : MonoBehaviour
{
    public float timeBetweenSpawn = 1.5f;
    private float time = 0;
    public GameObject prefabObstacle;

    public float randomHeight;

    // Update is called once per frame
    void Update()
    {
        if (time > timeBetweenSpawn)
        {
            GameObject truc = Instantiate(prefabObstacle);
            truc.transform.position = transform.position + new Vector3(0, Random.Range(-randomHeight, randomHeight), 0);

            time = 0;

            Destroy(truc, 5);
        }

        time += Time.deltaTime;
    }
}
