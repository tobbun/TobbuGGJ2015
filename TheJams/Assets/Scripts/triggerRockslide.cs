﻿using UnityEngine;
using System.Collections;

public class triggerRockslide : MonoBehaviour {

	private bool hasTriggeredRockslide = false;

	// Use this for initialization
	void OnTriggerEnter2D () {
		if (!hasTriggeredRockslide) {
			Debug.Log("play rockslide");
			AudioManager.PlaySound("FX/One-Shots/Rockslide", gameObject);
			hasTriggeredRockslide = true;
		}
	}	
}
