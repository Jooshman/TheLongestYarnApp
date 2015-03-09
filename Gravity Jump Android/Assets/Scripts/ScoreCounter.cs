using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {
	public Text scoreText;
	public Text highScoreText;
	public Text congratsText;
	public Text longyarnText;
	public Text newHighText;
	public static int score = 0;
	public static int highScore = 0;
	public static bool newHigh = false;
	// Use this for initialization

	void Start () {

		//scoreText = gameObject.GetComponent<Text>();
		//score = 0;
		//scoreText.text = "Score: " + score/2;
		//highScoreText.text = "High Score: " + highScore;
	}

	public int getScore(){
		return score/2;
	}

	public void setScore(int newValue){
		score = newValue;
	}

	public int getHighScore(){
		return highScore;
	}

	public void hitPoints(){
		score += 100;
	}

	public void setBool(bool poop){
		newHigh = poop;
	}

	public void setHighScore(int newHighScore){
		highScore = newHighScore;
		Debug.Log ("YELLO");
		newHigh = true;

	}
	// Update is called once per frame
	void FixedUpdate () {
		if (Application.loadedLevel == 2) {
			scoreText.text= getScore ().ToString();
			highScoreText.text =  getHighScore().ToString();
			if (newHigh == true) {
				congratsText.text = "but you made ";
				newHighText.text = "new";
				longyarnText.text = "the longest yarn";
			}
			return;
		}

		score++;
		scoreText.text = "Score: " + score/2;
		//highScoreText.text = "High Score: " + highScore;
	}

}
