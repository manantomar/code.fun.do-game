using UnityEngine;
using System.Collections;

public class pups : MonoBehaviour {
	public GameObject prefab;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "hit") {
			Instantiate (prefab, new Vector3 (transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
			Destroy (gameObject);
		}
	}
}
