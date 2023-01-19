using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Orion
{
    public class ButtonSpawner : MonoBehaviour
    {

        public RectTransform parent;
        public Ingredient[] ingredientsList;
        public Button buttonPrefab;
        public Transform ingredientSpawner;
        public IngredientManager ingredientManager;

        // Start is called before the first frame update
        void Start()
        {
            Shuffle();
            for (int i = 0; i < ingredientsList.Length; i++)
            {
                GameObject thisInstance = parent.GetChild(i).gameObject;
                ButtonScript buttonScript = thisInstance.GetComponent<ButtonScript>();
                buttonScript.assignedIngredient = ingredientsList[i];
            }

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void Shuffle()
        {
            for (int i = 0; i < ingredientsList.Length - 1; i++)
            {
                int rnd = Random.Range(i, ingredientsList.Length);
                var tempElement = ingredientsList[rnd];
                ingredientsList[rnd] = ingredientsList[i];
                ingredientsList[i] = tempElement;
            }
        }

    }
}

