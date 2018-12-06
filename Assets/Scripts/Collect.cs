using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {

	//*** Properties
	public ParticleSystem particlesRegular;
	public ParticleSystem particlesCollected;

	//*** Variables
	private bool collected = false;

	//*** Unity Methods
	private void OnTriggerEnter(Collider collision) {

		//*** IF not alreay collected
		if(!collected) {
	
			//*** Try to get teh player object
			Player player = collision.gameObject.GetComponent<Player>();
	
			//*** if the player object is valid
			if(player != null){

				//*** Set Collected
				collected = true;

				//*** Turn off regular and play collected
				particlesRegular.Stop();
				particlesCollected.Play();

				//*** Give player score
				Game.instance.GiveScore();
			}
		}
	}
	private void OnCollisionEnter(Collision collision) {
	}
}
