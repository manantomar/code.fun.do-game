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
	public GameObject screen;
	public Text score;
	public Text hiscore;
	public Text game_over;
	public float point;
	public float hitforce = 100.0f;
	public bool chip;
	public Text start;
	public GameObject screen_1;
	public Button play;

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

		//rb.AddForce(new Vector3(0,-10,0));
	}

	//void FixedUpdate () {

		//speed = (transform.position - prevpos).magnitude; 
		//prevpos = transform.position;
	//}

	void OnTriggerEnter (Collider other){

		if (other.gameObject.tag == "hit_for_cube") {
			rb.AddForce ((vec.normalized)*hitforce);

			point += 1;
			score.GetComponent<Text> ().text = "SCORE  " + point;
			score.GetComponent<Text> ().text = "SCORE  " + point;
			score.GetComponent<Text> ().text = "SCORE  " + point;
			score.GetComponent<Text> ().text = "SCORE  " + point;
			score.GetComponent<Text> ().text = "SCORE  " + point;
		}

		if (other.gameObject.tag == "game_over") {
			if (GameObject.FindGameObjectsWithTag ("hit").Length == 1) {
				game_over.GetComponent<Text> ().enabled = true;
				score.GetComponent<Text> ().enabled = false;
				screen.GetComponent<Renderer> ().enabled = true;
				chip = true;

			}
			Destroy (gameObject);

		}
	}
		

	public void start_play(){

		score.GetComponent<Text> ().enabled = true;
		hiscore.GetComponent<Text> ().enabled = true;
		start.GetComponent<Text> ().enabled = false;
		screen_1.GetComponent<Renderer> ().enabled = false;
		play.GetComponent<Image> ().enabled = false;
	}
}
