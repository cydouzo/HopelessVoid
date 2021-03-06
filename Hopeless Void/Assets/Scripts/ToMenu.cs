﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToMenu : MonoBehaviour {



	private BoxCollider2D box;
	private RectTransform rect;

	void Awake(){
		rect = GetComponent<RectTransform> ();
		box = GetComponent<BoxCollider2D> ();
	}

	public void Update(){
		box.size = new Vector2(rect.rect.width,rect.rect.height);
	}

	private bool pushed = false;

	void OnMouseOver() {
		if (Input.GetMouseButtonDown (0)) {
			if (!pushed) {
				Pushed ();
				pushed = true;
			}
		} else if (pushed) {
			pushed = false;
		}
	}

	void Pushed(){
		GUIHandler.instance.Intro ();
		GameHandler.instance.SetState ("MenuScene");
	}
}
	// Update is called once per frame
