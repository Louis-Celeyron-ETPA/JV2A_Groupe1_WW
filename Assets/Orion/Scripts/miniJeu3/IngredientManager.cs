using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{
    public class IngredientManager : MonoBehaviour
    {
        public CustomerOrder customerOrder;
        public List<Ingredient> ingredientsSpawned = new List<Ingredient>();
        public int layerOrder = 5;

        [SerializeField]
        private float _failRateAllowed = 0.2f;
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
            if(ingredientsSpawned[ingredientsSpawned.Count - 1].ingredientName == "topBun")
            {
                ingredientsSpawned.RemoveAt(ingredientsSpawned.Count - 1); //remove top bun to easily compare with order
                return true;
            }
            else if (ingredientsSpawned.Count >= 10)
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
            int _numberOfDifferences = 0;

            if (customerOrder.order.Count != ingredientsSpawned.Count)
            {
                Debug.Log("fail");
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
            else
            {
                for (int i = 0; i < customerOrder.order.Count; i++)
                {
                    if (customerOrder.order[i].ingredientName != ingredientsSpawned[i].ingredientName)
                    {                 
                        _numberOfDifferences++;
                    }                
                }

                if(_numberOfDifferences == 0)
                {
                    Debug.Log("perfect");
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Perfect);
                }
                else if(_numberOfDifferences <= Mathf.Round(customerOrder.order.Count * _failRateAllowed))
                {
                    Debug.Log("success");
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
                }
                else
                {
                    Debug.Log("fail");
                    ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
                }

            }
        }
    }
}

