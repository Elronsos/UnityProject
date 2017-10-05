using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;

public class Setup : MonoBehaviour {

	public Text mPosition;
	static public Vector2 mousePos;
	private Vector2 mousePoint;


	// Use this for initialization
	void Start () {
		SetMousePos ();
	}
		

	// Update is called once per frame
	void Update () {
		mousePoint = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		mousePos.x = Mathf.Round (mousePoint.x);
		mousePos.y = Mathf.Round (mousePoint.y);
		if (Input.GetMouseButtonDown(0)){
			SetMousePos ();
		}
	}

	void SetMousePos(){
		mPosition.text = "X-Achse: " + mousePos.x.ToString () + "Y-Achse: " + mousePos.y.ToString ();
	}
}