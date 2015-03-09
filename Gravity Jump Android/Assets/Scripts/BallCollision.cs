using UnityEngine;
using System.Collections;

public class BallCollision : MonoBehaviour {
	ScoreCounter scoreCount = new ScoreCounter ();
	public bool protect;
	// Use this for initialization
	void OnCollisionEnter (Collision collision){
		if (collision.gameObject.tag == "cube") {
			//Destroy (collision.gameObject);
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
}
