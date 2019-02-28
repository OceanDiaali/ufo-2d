using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {

	public Text scoreText;
	public static int scoreValue;

	// Use this for initialization
	void Start () {
		scoreValue = 0;

	}
	
	// Update is called once per frame
	void Update () {
		scoreText.text = "Score: " + scoreValue;
	}
}
