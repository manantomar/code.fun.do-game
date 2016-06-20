using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	// Use this for initialization
	float xDeg;
	float yDeg;
	Quaternion fromRotation;
	Quaternion toRotation;
	public float lerpSpeed = 16.0f;
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0)) {
			
			xDeg += Input.GetAxis ("Mouse X");
			yDeg += Input.GetAxis ("Mouse Y");
			fromRotation = transform.rotation;
			toRotation = Quaternion.Euler(2*xDeg,2*yDeg,2*yDeg);
			transform.rotation = Quaternion.Lerp(fromRotation,toRotation,Time.deltaTime  * lerpSpeed);
		}

	}
		
		
}
