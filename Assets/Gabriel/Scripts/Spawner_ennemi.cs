using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Osborne
{

    public class Spawner_ennemi : MonoBehaviour
    {
        public float delay = 1f;
        public GameObject blue_car_1;
        public GameObject blue_car_2;
        public GameObject blue_car_3;
        public int trie;

        // Start is called before the first frame update
        void Start()
        {
            InvokeRepeating("Spawn", delay, delay);
        }

        void Spawn()
        {
            trie = Random.Range(1, 3);
            if (trie == 1)
            {
               Instantiate(blue_car_1, new Vector3(5, 17, 2.6f), Quaternion.identity); // Quaternion prevents rotation
            }

            if (trie == 2)
            {
                Instantiate(blue_car_2, new Vector3(1, 17, 2.6f), Quaternion.identity); // Quaternion prevents rotation
            }

            if (trie == 3)
            {
                Instantiate(blue_car_3, new Vector3(6, 17, 2.6f), Quaternion.identity); // Quaternion prevents rotation
            }
        }

    }

}
