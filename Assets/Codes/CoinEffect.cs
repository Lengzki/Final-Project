using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinEffect : MonoBehaviour {

	public static AudioSource Coin_sound;

	void Start () {
		Coin_sound = GetComponent<AudioSource>();
	}
	
	void Update () {
		transform.Rotate(3,0,0);
	}
}
