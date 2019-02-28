using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownScript : MonoBehaviour {

	public float timeLeft = 15.0f;
	public Text startText;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		startText.text = (timeLeft).ToString ("0");
		if (timeLeft <= 5) {
			startText.color = Color.red;
		}
		if (timeLeft < 0) {
			timeLeft = 0;
			startText.text = "Time Up!";
		}
	}
}
