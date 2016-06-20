using UnityEngine;
using System.Collections;

public class speed_variation : MonoBehaviour {

	// Use this for initialization
	public float speed ;
	Vector3 vec ;
	Rigidbody rb;
	public Vector3 force ;
	public GameObject plane;
	void Start () {

		rb = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		//vel = rb.velocity.normalized;
		//if (rb.velocity.magnitude > 1.2) {
			//rb.velocity -= 0.05f * Time.deltaTime * vel;
		//}
		vec = plane.transform.position -  gameObject.transform.position;
	}

	//void FixedUpdate () {

		//speed = (transform.position - prevpos).magnitude; 
		//prevpos = transform.position;
	//}

	void OnTriggerEnter (Collider other){

		if (other.gameObject.tag == "hit") {
			rb.AddForce (vec*100);
		}
	}
}
