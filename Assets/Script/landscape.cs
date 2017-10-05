using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landscape : MonoBehaviour {

    [SerializeField]
    private GameObject finalObject;

    int[,,] field = new int[9, 9, 2];

    // Use this for initialization
    void Start() {
        int maxX = field.GetLength(0);
        int maxY = field.GetLength(1);
        for (int i = 0; i < maxX; i++)
        {
            field[i, 0, 0] = 1;
            field[i, 0, 1] = 1;
            field[i, maxY, 0] = 1;
            field[i, maxY, 1] = 1;
        }
        for (int j = 0; j < maxY; j++) {
            field[j, 0, 0] = 1;
            field[j, 0, 1] = 1;
            field[j, maxX, 0] = 1;
            field[j, maxX, 1] = 1;
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
