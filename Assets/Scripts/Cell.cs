using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chester {
    public class Cell : MonoBehaviour {
        private GameObject data;
        private int x, y;
        private Material color;

        public Cell(GameObject data, Material color, int x, int y) {
            this.data = data;
            this.x = x;
            this.y = y;
        } 


    }
}