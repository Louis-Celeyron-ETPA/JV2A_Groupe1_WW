using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Orion
{
    public class CustomerOrder : MonoBehaviour
    {
        public List<Ingredient> order = new List<Ingredient>();
        public int ingredientNumber = 3;

        [SerializeField]
        private Image _ingredientImage;
        [SerializeField]
        private RectTransform _ingredientImageParent, _topBun, _bottomBun;
        [SerializeField]
        private Ingredient[] _possibleIngredients;

        private Vector3 _imagePosition;
        private float _baseSpacing;

        // Start is called before the first frame update
        void Start()
        {
            _baseSpacing = (_topBun.position.y - _bottomBun.position.y) / ingredientNumber;

            CreateOrder();
            for (int i = 0; i < order.Count; i++)
            {
                Debug.Log(order[i].ingredientName);
            }
            DisplayOrder();

        }

        private void CreateOrder()
        {
            for (int i = 0; i < ingredientNumber; i++)
            {
                order.Add(_possibleIngredients[Random.Range(0, _possibleIngredients.Length)]);
            }
        }

        private void DisplayOrder()
        {
            var _spacing = _baseSpacing * 0.5f;
            for (int i = 0; i < ingredientNumber; i++)
            {
                _imagePosition = new Vector3(_bottomBun.position.x, _bottomBun.position.y + _spacing, _bottomBun.position.z);
                Image thisInstance = Instantiate(_ingredientImage, _imagePosition, Quaternion.identity, _ingredientImageParent);
                thisInstance.sprite = order[i].ingredientSprite;
                _spacing += _baseSpacing;
            }
        }
    }
}

