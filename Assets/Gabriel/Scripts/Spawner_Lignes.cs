using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gabriel
{ 

public class Spawner_Lignes : MonoBehaviour
{
    public float delayLigne = 1f;
    public GameObject ligne;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(LaunchSpawn());
    }

    public IEnumerator LaunchSpawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(delayLigne);
            Spawn();
        }
    }

    void Spawn()
    {
        Instantiate(ligne, transform);
    }
}

}
