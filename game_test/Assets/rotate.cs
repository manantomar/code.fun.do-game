﻿using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	// Use this for initialization
	public float xDeg;
	public float zDeg;
	Quaternion fromRotation;
	Quaternion toRotation;
	Quaternion toRotation_1;
	public float lerpSpeed = 16.0f;
	public float lerpSpeed_1 = 0.5f;
	public bool flag;
	void Start () {

		fromRotation = transform.rotation;
	}
	
	// Update is called once per frame
	void Update () {
		//if((Input.touchCount > 0)){
			if(Input.GetMouseButton(0)){

			//xDeg += Input.touches[0].deltaPosition.x;
			//yDeg += Input.touches[0].deltaPosition.y;
			xDeg -= Input.GetAxis("Mouse X");
			zDeg += Input.GetAxis("Mouse Y");
			//if ((transform.rotation.eulerAngles.x < 100) && (transform.rotation.eulerAngles.y < 180) && (transform.rotation.eulerAngles.z < 100)) {
				//flag = true;
			if (4*xDeg > 32)
				xDeg = 8;
			if (4*xDeg < -32)
				xDeg = -8;
			
			if (4*zDeg > 32)
				zDeg =8;
			if (4*zDeg < -32)
				zDeg = -8;
			
				fromRotation = transform.rotation;
				toRotation = Quaternion.Euler (4*zDeg , 4*xDeg , 0);
				toRotation_1 = Quaternion.Euler (0, 0, 0);
				transform.rotation = Quaternion.Lerp (fromRotation, toRotation, Time.deltaTime * lerpSpeed);
			//}

			//else {
			//	flag = false;
			//	transform.rotation = Quaternion.RotateTowards (transform.rotation, fromRotation, lerpSpeed_1);
			//}




		}

	}
		
		
}
