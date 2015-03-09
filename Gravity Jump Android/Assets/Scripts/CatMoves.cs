using UnityEngine;
using System.Collections;

public class CatMoves : MonoBehaviour {
	// Use this for initialization
	int clock = 0;
	bool inAir = false;
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		clock++;
		if (Random.Range (0, 3) == 1) {
			if(clock > 10 && inAir == false){
				jump();
				inAir = true;
			}
			else if( clock > 20 && inAir == true){
				fall();
				inAir = false;
				clock = 0;
			}
		}
	}

	void jump(){
		float x = transform.position.x;
		float y = transform.position.y;
		float z = transform.position.z;
		transform.position = new Vector3 (x, y + .2f, z);
	}

	void fall(){
		float x = transform.position.x;
		float y = transform.position.y;
		float z = transform.position.z;
		transform.position = new Vector3 (x, y - .2f, z);
	}
}
