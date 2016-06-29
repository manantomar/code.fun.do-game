using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class speed_variation : MonoBehaviour {

	// Use this for initialization
	public float speed ;
	Vector3 vec ;
	Rigidbody rb;
	public Vector3 force ;
	public GameObject plane;
	public Text score;
	public float point;

	void Start () {

		rb = gameObject.GetComponent<Rigidbody> ();
		score.GetComponent<Text> ().text = "SCORE 0";
		point = 0.0f;
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

		if (other.gameObject.tag == "hit_for_cube") {
			rb.AddForce (vec*100);

			point += 5;
			score.GetComponent<Text> ().text = "SCORE  " + point;
		}
	}
}
