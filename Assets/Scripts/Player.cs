using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	//*** Properties
	public int playerIndex;
	public float speedX;
	public float speedY;
	public string axisHorizontal;
	public string axisVertical;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//*** Get the directional input
		float xHorizontal = Input.GetAxis(axisHorizontal);
		float xVertical = Input.GetAxis(axisVertical);

		//*** Update the position
		Vector3 vPosition = transform.position;
		vPosition.x += xHorizontal * Time.deltaTime * speedX * -1;
		vPosition.z += xVertical * Time.deltaTime * speedY * -1;
		transform.position = vPosition;
	}
}
