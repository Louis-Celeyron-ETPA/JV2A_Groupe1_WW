using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Orion
{
    public class VictoryManager : MonoBehaviour
    {
        public BallMovements ballMovements;
        public BallCollider ballCollider;
        private float _currentTime;
        [SerializeField]
        private float _perfectTimeLimit;
        private bool _ended = false;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            _currentTime += Time.deltaTime;

            if(ballMovements.isThrown && ballMovements.touchedGround && !_ended)
            {
                CheckVictory();
            }

        }

        private void CheckVictory()
        {
            if (ballCollider.isEjected && _currentTime <= _perfectTimeLimit)
            {
                _ended = true;
                Debug.Log("perfect");
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Perfect);
            }
            else if (ballCollider.isEjected && _currentTime > _perfectTimeLimit) 
            {
                _ended = true;
                Debug.Log("success");
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);

            }
            else
            {
                _ended = true;
                Debug.Log("fail");
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }
        }
    }
}