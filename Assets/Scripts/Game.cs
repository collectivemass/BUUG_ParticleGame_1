using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Game : MonoBehaviour {

	//*** Static
	public static Game instance;

	//*** Properties
	public TextMeshPro textScore;

	//*** Variables
	private int score = 0;

	//*** Unity Methods
	private void Awake() {
	
		//*** Set Singleton
		instance = this;
	}
	private void Start () {

		//*** Reset score
		score = 0;

		//*** Draw score
		RenderScore();
	}
	
	//*** Main Methods
	private void RenderScore() {
		textScore.text = score.ToString();
	}
	public void GiveScore() {

		//*** Give score and show
		score++;
		RenderScore();
	}
}
