using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{
    public class Ingredient : MonoBehaviour
    {
        // Start is called before the first frame update
        public string ingredientName;
        public Sprite ingredientSprite;
        public GameObject prefab;

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Instantiation(Vector3 vector)
        {
            Instantiate(prefab, vector, Quaternion.identity);
        }
    }
}

