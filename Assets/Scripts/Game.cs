using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class Game : MonoBehaviour {

	//*** Static
	public static Game instance;

	//*** Properties
	public TextMeshPro[] textScores;

	//*** Variables
	private int[] scores = new int[] {0, 0};

	//*** Unity Methods
	private void Awake() {
	
		//*** Set Singleton
		instance = this;
	}
	private void Start () {

		//*** Reset score
		SetScore(0, 0);
		SetScore(1, 0);

		//*** Draw score
		RenderScore();
	}
	
	//*** Main Methods
	private void RenderScore() {

		for(int i=0; i<textScores.Length; i++) {
			textScores[i].text = scores[i].ToString("###,##0");
		}
	}
	public void GiveScore(int pIndex) {

		//*** Give score and show
		scores[pIndex]++;
		RenderScore();
	}
	private void SetScore(int pIndex, int pScore) {

		//*** Give score and show
		scores[pIndex] = pScore;
	}
}
