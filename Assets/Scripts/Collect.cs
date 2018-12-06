using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {

	//*** Properties
	public float speedX;
	public float speedY;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//*** Get the directional input
		float xHorizontal = Input.GetAxis("Horizontal");
		float xVertical = Input.GetAxis("Vertical");

		//*** Update the position
		Vector3 vPosition = transform.position;
		vPosition.x += xHorizontal * Time.deltaTime * speedX;
		vPosition.z += xVertical * Time.deltaTime * speedY;
		transform.position = vPosition;
	}
}
