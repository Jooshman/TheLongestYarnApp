using UnityEngine;
using System.Collections;
using System.Timers;
using UnityEngine.UI;

public class MovementControl : MonoBehaviour {
	public KeyCode space;
	public const int CEIL_POS = 7;
	public const float FLOOR_POS =  0.6f;
	public static bool inAir = false;
	public int gravityClock = 0;
	public static int gravity = 1;
	public static int timesPlayed = 1;
	public static int rotate = 0;
	
	void Start(){
		if (gravity == -1) {
			Physics.gravity = new Vector3(0,Physics.gravity.y*-1,0);
			gravityClock = 0;
			rotate = 0;
			gravity*=-1;
		}
		if(timesPlayed == 1){
			Physics.gravity = new Vector3 (0, Physics.gravity.y*2, 0);
			
		}
		Debug.Log (Physics.gravity.y);
		//gravity = 1;
		//new CreateCubes(1);
		//GetComponent<Rigidbody> ().AddForce (new Vector3 (-20, 0, 0), ForceMode.Impulse);
		//GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 2f*gravity,0), ForceMode.Impulse);
		
		//test.transform.position = new Vector3 (-12.93f, 0.38f, 14.47f);
		timesPlayed++;
	}
	
	void Update(){
		if (Input.touchCount > 0 && Input.GetTouch(0).position.x > Screen.width/2 && inAir == false) {
			inAir = true;
			if(gravity == -1){
				GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 2f*gravity,0), ForceMode.Impulse);
			}
			else{
				GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 2f*gravity,0), ForceMode.Impulse);
			}
		}
		
		if(Input.touchCount > 0 && gravityClock > 10 && Input.GetTouch(0).position.x < Screen.width/2){
			//GetComponent<Rigidbody>().useGravity = false;
			Physics.gravity = new Vector3(0,Physics.gravity.y*-1,0);
			gravityClock = 0;
			gravity *= -1;
		}	
	}
	
	void FixedUpdate () {
		if (rotate == 0) {
			transform.Rotate (new Vector3 (0, 0, -15));
		} else {
			transform.Rotate (new Vector3 (0, 0, 15));
		}
		//GetComponent<Rigidbody> ().MovePosition (new Vector3 (-12.93f, 0.38f, GetComponent<Rigidbody> ().position.z)); 
		//scoreText.text = "Score: " + score;
				if (Input.GetKey (space) && inAir == false) {
					inAir = true;
					if(gravity == -1){
						GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 2f*gravity,0), ForceMode.Impulse);
					}
					else{
						GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 2f*gravity,0), ForceMode.Impulse);
					}
					//GetComponent<Rigidbody> ().AddForce (new Vector3 (0, 2f, 0), ForceMode.Impulse);
				}
		
				if(Input.GetKey(KeyCode.S) && gravityClock > 10){
					//GetComponent<Rigidbody>().useGravity = false;
					Physics.gravity = new Vector3(0,Physics.gravity.y*-1,0);
					gravityClock = 0;
					gravity *= -1;
				}	
		
		if (GetComponent<Rigidbody> ().position.y < FLOOR_POS) {
			inAir = false;
			rotate = 0;
		}
		if (GetComponent<Rigidbody> ().position.y > CEIL_POS) {
			inAir = false;
			rotate = 1;
		}
		gravityClock++;
	}
}
