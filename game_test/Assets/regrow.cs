using UnityEngine;
using System.Collections;



public class regrow : MonoBehaviour {

	// Use this for initialization
	public float time = 5.0f;
	public GameObject ball;
	public bool flag;

	void Start () {
	
		//transform.localScale = new Vector3(0,1,1);

	}
	
	// Update is called once per frame
	void Update () {
	
		//transform.localScale += new Vector3(0.1F, 0, 0);
		if (flag == true) {

			if(transform.localScale.x < 1.311)
			transform.localScale += new Vector3 (Time.deltaTime / time, 0, 0);
		}

	}

	void OnTriggerEnter (Collider other){

		if (other.gameObject.tag == "hit") {

			flag = true;
			transform.localScale = new Vector3 (0, 1, 1);
		}

	}
}
