using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Landscape : MonoBehaviour {

	[SerializeField]
	private GameObject grass;

	[SerializeField]
	private GameObject tree;

	[SerializeField]
	private GameObject house;

	int[,,] field = new int[9, 9, 2];
	private Vector2 pos;

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

		for (int i = 0; i < field.GetLength(0); i++) {
			for (int j = 0; j < field.GetLength (1); j++) {
				pos.x = i;
				pos.y = j;

				switch(field[i,j,0]){

				case 0: 
					Instantiate (grass, pos, Quaternion.identity);
					break;

				case 1: 
					Instantiate (tree, pos, Quaternion.identity);
					break;
				
				case 2:
					Instantiate (house, pos, Quaternion.identity);
					break;

				default:
					break;
				}
			}
		}
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Instantiate (grass, Setup.mousePos, Quaternion.identity);
		}
	}
}