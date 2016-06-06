using UnityEngine;
using System.Collections;

public class speed_variation : MonoBehaviour {

	// Use this for initialization
	public float speed ;
	Vector3 prevpos ;
	Rigidbody rb;
	Vector3 vel ;
	void Start () {
	
		rb = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
		vel = rb.velocity.normalized;
		if (rb.velocity.magnitude > 1.2) {
			rb.velocity -= 0.05f * Time.deltaTime * vel;
		}
	}

	void FixedUpdate () {

		speed = (transform.position - prevpos).magnitude; 
		prevpos = transform.position;
	}
}
