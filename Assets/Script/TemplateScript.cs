﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplateScript : MonoBehaviour {
	
	[SerializeField]
	private GameObject finalObject;

	[SerializeField]
	private LayerMask allTilesLayer;

	private Vector2 mousePos;

	// Update is called once per frame
	void Update () {
		mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		transform.position = new Vector2 (Mathf.Round (mousePos.x), Mathf.Round (mousePos.y));

		if (Input.GetMouseButtonDown (0)) {

			Vector2 mouseRay = Camera.main.ScreenToWorldPoint (transform.position);
			RaycastHit2D rayHit = Physics2D.Raycast (mousePos, Vector2.zero, Mathf.Infinity, allTilesLayer);

			if (rayHit.collider == null) {
				Instantiate (finalObject, transform.position, Quaternion.identity);
			}
		}
	}
}
