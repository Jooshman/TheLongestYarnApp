using UnityEngine;
using System.Collections;

public class BallCollision : MonoBehaviour {
	ScoreCounter scoreCount = new ScoreCounter ();
	public Rigidbody shield;
	public bool protect = false;


	void OnCollisionEnter (Collision collision){
		if (collision.gameObject.tag == "cube") {
			if (protect == false) {
				if (scoreCount.getHighScore () < scoreCount.getScore ()) {
					scoreCount.setHighScore (scoreCount.getScore ());
					scoreCount.setBool (true);
				}
				Application.LoadLevel (2);
			} else {
				Destroy (collision.gameObject);
				protect = false;
			}
		} else if (collision.gameObject.tag == "Points") {
			Destroy (collision.gameObject);
			scoreCount.hitPoints ();
		} else if (collision.gameObject.tag == "shield") {
			Destroy(collision.gameObject);
			protect = true;
		}
	}

	void FixedUpdate(){
		if (protect == true) {
			shield.gameObject.SetActive (true);
		} else {
			shield.gameObject.SetActive (false);
		}
	}
}
