﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Building {
	NONE,
	CAPITAL,
	FARM,
	MINE
};

public class HexagonBehavior : MonoBehaviour {

	public SpriteRenderer selfRenderer;
	public bool isFlat;
	public Vector2 coordinates;

	public void HexagonInitialize(bool isFlat, Sprite sprite, Vector2 c){
		this.isFlat = isFlat;
		selfRenderer.sprite = sprite;
		this.coordinates = c;
	}
	void Awake() {
		
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
