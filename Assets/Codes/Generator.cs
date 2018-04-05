using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour {

	public Transform Camera;
	public Transform[] stages;
	public Transform[] Loops;
	public Transform coin;

	int rannum = 0;
	float random;
	float random2;
	int hoops_ran;
    float x_path = -9f;
	float step = -2.5f;
	float pos = -0.6f;
	float pos2 = -1f;
	int num_coin = 24;
	void Start () {

		//Background Renderer 2x
		for(int x=0; x<2; x++){
			rannum = Random.Range(0,9);
			Instantiate(stages[rannum], new Vector3(step,0,0), stages[rannum].rotation);
			step += -5f;
		}

		for(int x=0; x<num_coin; x++){
			random = Random.Range(-0.2f,0.2f);
	
			Instantiate(coin, new Vector3(pos,random,0.2f), coin.rotation);
			pos += -0.4f;
		}

		num_coin += 1;

		for(int x=0; x<10; x++){
			random2 = Random.Range(-0.2f,0.2f);
			hoops_ran = Random.Range(0,2);
			while(random == random2){
				random2 = Random.Range(-0.2f,0.2f);
			}
			Instantiate(Loops[hoops_ran], new Vector3(pos2,random2,0.18f), Loops[hoops_ran].rotation);
			pos2 += -1f;
		}
	}
	
	void Update () {
		//Endless Background Code
		if(MoveCamera.z_camera<=x_path){
			for(int x=0; x<2; x++){
				rannum = Random.Range(0,9);
				Instantiate(stages[rannum], new Vector3(step,0,0), stages[rannum].rotation);
				step += -5f;
			}
			x_path += -10f;

			//Coin Generator
			for(int x=0; x<num_coin; x++){
				random = Random.Range(-0.2f,0.2f);
				Instantiate(coin, new Vector3(pos,random,0.2f), coin.rotation);
				pos += -0.4f;
				
			}
			num_coin += 1;

			//Loops Generator
			for(int x=0; x<10; x++){
				random2 = Random.Range(-0.2f,0.2f);
				hoops_ran = Random.Range(0,3);
				while(random == random2){
					random2 = Random.Range(-0.2f,0.2f);
				}
				Instantiate(Loops[hoops_ran], new Vector3(pos2,random2,0.18f), Loops[hoops_ran].rotation);
				pos2 += -1f;
			}
		}	
	}

}
