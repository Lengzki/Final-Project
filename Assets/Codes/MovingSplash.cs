using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingSplash : MonoBehaviour {

	float speed = 20f;
	Vector2 position;

	// Use this for initialization
	void Start () {
		transform.Translate (0, 0,0);
		position = transform.position;
	}

	// Update is called once per frame
	void Update () {
		float newpos = Mathf.Repeat (Time.time * speed, 1800);
		transform.position = position + Vector2.right * newpos;
	}
}
