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

    // Start is called before the first frame update
    void Start()
        {
            GameObject img = transform.GetChild(0).gameObject;
            img.GetComponent<Image>().sprite = assignedIngredient.ingredientSprite;
        }

        // Update is called once per frame
        void Update()
        {

        }


        public void IngredientSpawn()
        {
            assignedIngredient.Instantiation(spawner.position);

        }
    }

}

