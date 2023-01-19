using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace Orion
{
    public class ButtonScript : MonoBehaviour
    {
        public Ingredient assignedIngredient;
        public Transform spawner;
        public Image img;
        public IngredientManager ingredientManager;

    // Start is called before the first frame update
    void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            img.sprite = assignedIngredient.ingredientSprite;
        }


        public void IngredientSpawn()
        {
            Ingredient thisInstance = Instantiate(assignedIngredient, spawner.position, Quaternion.identity);
            thisInstance.spriteRenderer.sortingOrder = ingredientManager.layerOrder;
            ingredientManager.layerOrder++;
            ingredientManager.ingredientsSpawned.Add(thisInstance);
            Debug.Log(ingredientManager.ingredientsSpawned);
            if (ingredientManager.CheckIngredients())
            {
                Debug.Log("compare");
            }


        }
    }

}

