﻿using UnityEngine;
using System.Collections;

public class monitor_activation : MonoBehaviour {

	// Use this for initialization
	void Start () {

		if (Display.displays.Length > 1)
			Display.displays[1].Activate();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
