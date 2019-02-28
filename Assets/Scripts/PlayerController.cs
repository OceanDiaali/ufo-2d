using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	private AudioSource source;
	public Rigidbody2D rgbd2d;

	// Use this for initialization
	void Start () {
		rgbd2d = GetComponent<Rigidbody2D> ();
		source = GetComponent<AudioSource> ();
	}

	void OnCollisionEnter2D (Collision2D coll) {
		string gmObj = coll.gameObject.name;
		switch (gmObj) {
		case "coin":
			source.Play ();
			Destroy (coll.gameObject);
			ScoreScript.scoreValue++;
			break;

		case "coin2":
			source.Play ();
			Destroy (coll.gameObject);
			ScoreScript.scoreValue++;
			break;

		case "coin3":
			source.Play ();
			Destroy (coll.gameObject);
			ScoreScript.scoreValue++;
			break;

		case "coin4":
			source.Play ();
			Destroy (coll.gameObject);
			ScoreScript.scoreValue++;
			break;

		case "coin5":
			source.Play ();
			Destroy (coll.gameObject);
			ScoreScript.scoreValue++;
			break;

		}
		/*if (coll.gameObject.name == "coin") 
		{
			Destroy (coll.gameObject);
			ScoreScript.scoreValue++;
		}*/
	}
	
	// update per frame
	void Update() {
		transform.Rotate (0, 0, speed);

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Vector2 position = this.transform.position;
			position.x--;
			this.transform.position = position;
		} else if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			Vector2 position = this.transform.position;
			position.x++;
			this.transform.position = position;
		} else if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			Vector2 position = this.transform.position;
			position.y++;
			this.transform.position = position;
		} else if (Input.GetKeyDown(KeyCode.DownArrow))
		{
			Vector2 position = this.transform.position;
			position.y--;
			this.transform.position = position;
		}
	}
}
