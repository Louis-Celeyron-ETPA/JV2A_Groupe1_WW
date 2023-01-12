using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Orion
{
    public class ButtonSpawner : MonoBehaviour
    {

        public RectTransform parent;
        //public float spacing = 150f;
        public Ingredient[] ingredientsList;
        public Button buttonPrefab;
        public Transform ingredientSpawner;
        // Start is called before the first frame update
        void Start()
        {
            Shuffle();
            var newX = transform.position.x;
            for (int i = 0; i < ingredientsList.Length; i++)
            {
                Debug.Log(ingredientsList[i]);
                Vector3 newPosition = new Vector3(newX, transform.position.y, transform.position.z);
                transform.position = newPosition;
                Button thisInstance = Instantiate(buttonPrefab, newPosition, Quaternion.identity, parent);
                ButtonScript buttonScript = thisInstance.GetComponent<ButtonScript>();
                buttonScript.assignedIngredient = ingredientsList[i];
                buttonScript.spawner = ingredientSpawner;
                newX += Spacing();
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
                var tempGO = ingredientsList[rnd];
                ingredientsList[rnd] = ingredientsList[i];
                ingredientsList[i] = tempGO;
            }
        }

        public float Spacing()
        {
            var spacing = Screen.width * (130f / 756f);
            return spacing;
        }
    }
}

