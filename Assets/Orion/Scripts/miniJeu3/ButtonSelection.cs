using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Orion
{
    //On peut disable ce script ou l'Input Manager pour tester le mini jeu sur pc car la navigation dans l'ui est d�j� pr�vue de base dans Unity,
    //Mais du coup comme le jeu est pr�vu pour arcade et que je sais pas exactement comment fonctionne l'Input Manager, j'ai recr�� des fonctions pour naviguer entre les boutons de l'ui et je les aies mises sur l'input manager comme demand�.
    //Donc j'ai test� en mettant les fonctions sur des inputs diff�rents (TestInput) et �a marche, mais si on teste sur pc et qu'on clique sur un bouton � la souris, �a va faire les actions en double car l'input d'action de l'input manager est sur le clic de la souris aussi.

    public class ButtonSelection : MonoBehaviour
    {

        [SerializeField]
        private Button[] _buttonList;
        private int _currentlySelectedButtonIndex = 0;

        public void SelectRight()
        {
            if(_currentlySelectedButtonIndex != _buttonList.Length)
            {
                _currentlySelectedButtonIndex++;
                _buttonList[_currentlySelectedButtonIndex].Select();
            }
        }

        public void SelectLeft()
        {
            if (_currentlySelectedButtonIndex != 0)
            {
                _currentlySelectedButtonIndex--;
                _buttonList[_currentlySelectedButtonIndex].Select();
            }
        }

        public void ClickButton()
        {
            ExecuteEvents.Execute(EventSystem.current.currentSelectedGameObject, new BaseEventData(EventSystem.current), ExecuteEvents.submitHandler);
        }
    }
}

