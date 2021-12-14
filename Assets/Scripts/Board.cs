using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour {
    public GameObject whiteSquare, blackSquare;

    void Start() {
        InitializeBoard();
    }

    private void InitializeBoard() {
        for (int file = 0; file < 8; file++) {
            for (int rank = 0; rank < 8; rank++) {
                bool isWhite = (file + rank) % 2 != 0;
                var position = new Vector2(-3.5f + file, -3.5f + rank);

                if (isWhite) { Instantiate(whiteSquare, position, Quaternion.identity); }
                else         { Instantiate(blackSquare, position, Quaternion.identity); }
            }
        }
    }
}
