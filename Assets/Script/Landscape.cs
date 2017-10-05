using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Landscape : MonoBehaviour {

    [SerializeField]
    private GameObject finalObject;

    static int[,,] field = new int[9, 9, 2];
    private Vector2 pos;
    private int id;
    private int maxX;
    private int maxY;
    // Use this for initialization
    void Start() {
        maxX = field.GetLength(0);
        maxY = field.GetLength(1);
        for (int i = 0; i < maxX; i++) {
            field[i, 0, 0] = 1;
            field[i, 0, 1] = 1;
            field[i, maxY-1, 0] = 1;
            field[i, maxY-1, 1] = 1;
        }
        for (int j = 0; j < maxY; j++) {
            field[j, 0, 0] = 1;
            field[j, 0, 1] = 1;
            field[j, maxX-1, 0] = 1;
            field[j, maxX-1, 1] = 1;
        }
        for (int k = 0; k < maxX; k++) {
            for(int l = 0; l < maxY; l++) {
                pos.x = k;
                pos.y = l;
                id = field[k, l, 1];
                switch (id) {
                    case 0:
                        Instantiate(grass, pos, Quaternion.identity);
                        break;
                    case 1:
                        Instantiate(tree, pos, Quaternion.identity);
                        break;
                    case 2:
                        Instantiate(house, pos, Quaternion.identity);
                        break;
                }
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
