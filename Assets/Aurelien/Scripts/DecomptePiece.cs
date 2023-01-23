using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Aurelien
{
    public class DecomptePiece : MonoBehaviour
    {

        public float pieceRemaining = 10;
        public TextMeshProUGUI NombrePieceRestante;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            if (pieceRemaining == 0)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Perfect);
            }

            if (pieceRemaining <= 5)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Success);
            }

            if (pieceRemaining >= 5)
            {
                ManagerManager.GlobalGameManager.EndOfMinigame(MinigameRating.Fail);
            }

            NombrePieceRestante.text = "Pieces Restantes : " + pieceRemaining;
        }
        public void Truc()
        {
            pieceRemaining -= 1;
        }
    }
}