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
        public SpriteRenderer spriteRenderer;
        public Ingredient prefab;


        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Instantiation(Vector3 vector)
        {
            Ingredient thisInstance = Instantiate(prefab, vector, Quaternion.identity);
            thisInstance.spriteRenderer.sortingOrder = IngredientManager.layerOrder;
            IngredientManager.layerOrder++;
        }
    }
}

