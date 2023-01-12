using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Lignes : MonoBehaviour
{
    public float delay = 2f;
    public GameObject ligne;
    public Transform[] spawnOrigin;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LaunchSpawn());
    }

    public IEnumerator LaunchSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            Spawn();
        }
    }

    void Spawn()
    {
        var trie = Random.Range(0, 3);
        Instantiate(ligne, spawnOrigin[trie]);
    }
}
