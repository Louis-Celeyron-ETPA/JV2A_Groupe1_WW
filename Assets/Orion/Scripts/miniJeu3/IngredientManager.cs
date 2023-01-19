using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{
    public class IngredientManager : MonoBehaviour
    {
        public List<Ingredient> ingredientsSpawned = new List<Ingredient>();
        public int layerOrder = 5;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public bool CheckIngredients()
        {
            if(ingredientsSpawned.Count >= 10 || ingredientsSpawned[ingredientsSpawned.Count - 1].ingredientName == "topBun")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CompareToOrder()
        {

        }

    }
}

