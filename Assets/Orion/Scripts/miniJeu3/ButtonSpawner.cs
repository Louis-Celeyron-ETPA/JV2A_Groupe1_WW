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
        public UnityEventQueueSystem eventSystem;

        // Start is called before the first frame update
        void Start()
        {
            Shuffle();
            var newX = transform.position.x;
            for (int i = 0; i < ingredientsList.Length; i++)
            {
                Vector3 newPosition = new Vector3(newX, transform.position.y, transform.position.z);
                transform.position = newPosition;
                Button thisInstance = Instantiate(buttonPrefab, newPosition, Quaternion.identity, parent);
                if (i == 0)
                {
                    var eventSystem = EventSystem.current;
                    eventSystem.SetSelectedGameObject(thisInstance.gameObject, new BaseEventData(eventSystem));
                }
                ButtonScript buttonScript = thisInstance.GetComponent<ButtonScript>();
                buttonScript.assignedIngredient = ingredientsList[i];
                buttonScript.spawner = ingredientSpawner;
                buttonScript.ingredientManager = ingredientManager;
                newX += Spacing();
            }

            Destroy(this.gameObject);

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

        public float Spacing()
        {
            var spacing = Screen.width * (130f / 756f);
            return spacing;
        }
    }
}

