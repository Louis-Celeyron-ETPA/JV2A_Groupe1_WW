using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{

    public class Manager : MonoBehaviour
    {
        public Timer myTimer;
        public Movements myMovements;
        public float successTimeLimit = 7f;
        private bool _ended = false;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (!_ended && !myMovements.isDeflated && myTimer.gameFinished)
            {
                _ended = true;
                Debug.Log("perfect");
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Perfect);
            }
            else if (!_ended && myMovements.isDeflated && myTimer.currentTime >= successTimeLimit)
            {
                _ended = true;
                Debug.Log("success");
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }
            else if(!_ended && myMovements.isDeflated && myTimer.currentTime <= successTimeLimit)
            {
                _ended = true;
                Debug.Log("fail");
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
        
        }

    }
}


