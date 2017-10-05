using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public Vector2 mousePoint;


	// Update is called once per frame
	void Update () {
        mousePoint.x = Camera.main.ScreenToWorldPoint();
	}
}
