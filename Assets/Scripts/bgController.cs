﻿using UnityEngine;
using System.Collections;

public class bgController : MonoBehaviour {

	SpriteRenderer current_Bgsprite;

	public Sprite[] levels_Bgsprite;

	// Use this for initialization
	void Start () {

		current_Bgsprite = GetComponent<SpriteRenderer> ();
		changeBGSprite ();
	}

	void changeBGSprite(){
	
		if (StageLoader.instance.Stage <= 20) {
		
			current_Bgsprite.sprite = levels_Bgsprite [0];
		}
		if (StageLoader.instance.Stage >= 20 && StageLoader.instance.Stage <= 35) {

			current_Bgsprite.sprite = levels_Bgsprite [1];
		}
		if (StageLoader.instance.Stage >= 35 && StageLoader.instance.Stage <= 50) {

			current_Bgsprite.sprite = levels_Bgsprite [2];
		}
		if (StageLoader.instance.Stage >= 50 && StageLoader.instance.Stage <= 65) {

			current_Bgsprite.sprite = levels_Bgsprite [3];
		}
		if (StageLoader.instance.Stage >= 65 && StageLoader.instance.Stage <= 80) {

			current_Bgsprite.sprite = levels_Bgsprite [4];
		}
		if (StageLoader.instance.Stage >= 80 && StageLoader.instance.Stage <= 95) {

			current_Bgsprite.sprite = levels_Bgsprite [5];
		}
		if (StageLoader.instance.Stage >= 95 && StageLoader.instance.Stage <= 110) {

			current_Bgsprite.sprite = levels_Bgsprite [6];
		}
		if (StageLoader.instance.Stage >= 110 && StageLoader.instance.Stage <= 120) {

			current_Bgsprite.sprite = levels_Bgsprite [7];
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}