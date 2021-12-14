using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chester {
    public class Board : MonoBehaviour {
        public GameObject blackSquare;
        public GameObject whiteSquare;
        void Start() {
            GenerateBoard();
        }

        void GenerateBoard() {
            for (int file = 0; file < 8; file++) {
                for (int rank = 0; rank < 8; rank++) {
                    bool isWhite = (file + rank) % 2 != 0;
                    var position = new Vector2(-3.5f + file, -3.5f + rank);
                    GameObject square;
                    if (isWhite) { square = Instantiate(blackSquare, position, Quaternion.identity); }
                    else         { square = Instantiate(whiteSquare, position, Quaternion.identity); }
                }
            }
        }
    }
}