using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Orion
{
    public class ButtonSpawner : MonoBehaviour
    {

        public RectTransform parent;
        public float spacing = 150f;
        public Ingredient[] ingredientsList;
        public Button button;
        // Start is called before the first frame update
        void Start()
        {
            var newX = transform.position.x;

            for (int i = 0; i < ingredientsList.Length; i++)
            {
                Vector3 newPosition = new Vector3(newX, transform.position.y, transform.position.z);
                transform.position = newPosition;
                Button thisInstance = Instantiate(button, newPosition, Quaternion.identity, parent);
                GameObject img = thisInstance.transform.GetChild(0).gameObject;
                img.GetComponent<Image>().sprite = ingredientsList[i].ingredientSprite;
                newX += spacing;
            }

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

