using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {

	public static int score = 0;
	public static float z_camera;

	public static AudioSource Heli_sound;

	void Start () {
		Heli_sound = GetComponent<AudioSource>();
		Heli_sound.Play();
	}
	
	void Update () {
		GetComponent<Rigidbody>().velocity = new Vector3 (-0.3f,0,0);
		MoveCamera.z_camera = transform.position.x;
	}

}
