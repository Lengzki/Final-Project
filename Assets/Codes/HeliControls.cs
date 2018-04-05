using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HeliControls : MonoBehaviour {

	public KeyCode Boost;
	public GameObject Elisi;
	public ParticleSystem explode;
	
	AudioSource explosion;

	public Text scoreTxt;

	Rigidbody Heli;

	private float moveup = -0.3f;
	
	void Start () {
		Heli = GetComponent<Rigidbody>();
		explosion = GetComponent<AudioSource>();
	}
	
	void Update () {

		Heli.velocity = new Vector3 (-0.3f,moveup,0);

		if (Input.GetKey(Boost)){
			moveup = 0.3f;
    	} else {
			moveup = -0.3f;
		}
	}

	IEnumerator uncontrolled(){
		yield return new WaitForSeconds(.5f); 
		moveup = -0.3f;
	}

	void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "Obstacle"){ 
			MoveCamera.Heli_sound.Stop ();
			explosion.Play();
			explode.Play();
			StartCoroutine (HeliGone());     
		}
	}

	void OnTriggerEnter (Collider col){
		if(col.gameObject.tag == "point"){
			CoinEffect.Coin_sound.Play ();
			scoreTxt.text = "Score: " + MoveCamera.score.ToString();
			MoveCamera.score += 1;
			Destroy(col.gameObject);
		}

		if(col.gameObject.tag == "Obstacle"){ 
			MoveCamera.Heli_sound.Stop ();
			explosion.Play();
			explode.Play();
			StartCoroutine (HeliGone());   
		}
	}

	IEnumerator HeliGone()
    {
		yield return new WaitForSeconds(0.5f);
		transform.Translate(0,0,-1);
		StartCoroutine (ChangeScene());
    }

	IEnumerator ChangeScene()
    {
		yield return new WaitForSeconds(1f);
		MoveCamera.score = 0;
        scoreTxt.text = "Score: ";
		transform.Translate(0,0,0);
        SceneManager.LoadScene(0);
    }
}
