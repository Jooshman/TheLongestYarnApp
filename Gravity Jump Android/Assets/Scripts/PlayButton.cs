using UnityEngine;
using System.Collections;

public class PlayButton : MonoBehaviour {
	public GameObject canvas;
	public static int started = 0;
	void start(){
		if (started != 0) {
			canvas.SetActive(false);
		}

	}
	

	void FixedUpdate(){
	
		if (Input.GetKey(KeyCode.Space)) {
			Debug.Log ("YOOO");
			play (1);
		}
	}
	// Use this for initialization
	public void play(int i){
		ScoreCounter scoreCount = new ScoreCounter ();
		if (i == 1) {
			//scoreCount.congratsText.text = "";
			//scoreCount.longyarnText.text = "";
			//scoreCount.newHighText.text = "";
			scoreCount.setBool(false);
		}
		scoreCount.setScore(0);
		Application.LoadLevel (i);
//		if (i == 1) {
//			Debug.Log(Physics.gravity.y);
//			if(Physics.gravity.y < 0){
//				Physics.gravity = new Vector3(0, Physics.gravity.y*-1, 0);
//			}
//			Debug.Log(Physics.gravity.y);
//		}
	}

	public void endGame(){
		Application.Quit ();
	}	
}
