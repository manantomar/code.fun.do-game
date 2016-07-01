using UnityEngine;
using System.Collections;

public class hit_wall : MonoBehaviour {

	// Use this for initialization

	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other){

		if (other.gameObject.tag == "hit")
			Destroy (other.gameObject);
		
	}
}
