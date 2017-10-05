using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

	[SerializeField]
	private GameObject finalObject;

	int[, ,] field = new int[24, 12, 2];

	// Use this for initialization
	void Start () {
		for (int i = 0; i < field.GetLength(0); i++) {
			for (int j = 0; j < field.GetLength (1); j++) {

			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
