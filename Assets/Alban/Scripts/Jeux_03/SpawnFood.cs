using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Alban
{


    public class SpawnFood : MonoBehaviour
    {
        public GameObject[] Prefabs;
        public Transform startZone, EndZone;

        public IEnumerator SpawnerFood()
        {
            var timeIsRunning = FindObjectOfType<Timer_JeuxBouche>().timeIsRunning;
            while (timeIsRunning == true)
            {
                yield return new WaitForSeconds(1);
                Instantiate(
                    Prefabs[Random.Range(0, Prefabs.Length)], //Objet
                    Vector3.Lerp(startZone.position,EndZone.position,Random.Range(0f,1f)), //POsition
                    Quaternion.identity); //Rotation
            }
        }

        // Start is called before the first frame update
        void Start()
        {
            StartCoroutine(SpawnerFood());
        }

        // Update is called once per frame
        void Update()
        {


        }
    }
}
