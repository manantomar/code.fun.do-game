using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	// Use this for initialization
	float xDeg;
	float yDeg;
	Quaternion fromRotation;
	Quaternion toRotation;
	float lerpSpeed = 2.0f;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0)&&(transform.rotation. <= 45)&&(transform.rotation.eulerAngles.y <= 45)) {
			
			xDeg -= Input.GetAxis ("Mouse X");
			yDeg += Input.GetAxis ("Mouse Y");
			fromRotation = transform.rotation;
			toRotation = Quaternion.Euler(yDeg,xDeg,0);
			transform.rotation = Quaternion.Lerp(fromRotation,toRotation,Time.deltaTime  * lerpSpeed);
		}

	}
		
		
}
