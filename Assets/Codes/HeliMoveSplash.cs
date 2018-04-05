using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeliMoveSplash : MonoBehaviour {

	Rigidbody Heli;
	float moveup = 2f;
	// Use this for initialization
	void Start () {
		
		Heli = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space)) {
			SceneManager.LoadScene(1);
		}

		Heli.velocity = new Vector3 (0, moveup, 0);
		if (transform.position.y <= 2f) {
			moveup = 2f;
		} else if(transform.position.y >= 0f){
			moveup = -2f;
		}
	}
}
