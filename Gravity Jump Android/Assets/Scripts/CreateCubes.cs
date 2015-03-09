using UnityEngine;
using System.Collections;

public class CreateCubes : MonoBehaviour {
	public Rigidbody cubeFab;
	public Rigidbody doubleCubeFab;
	public Rigidbody point;
	public Rigidbody yarn;
	public Rigidbody sphere;
	public Rigidbody shield;
	public float lastYarn = 0.38f;
	private int cubeClock = 0;
	private int yarnClock = 0;
	
	// Update is called once per frame
	void FixedUpdate () {
		cubeClock++;
		yarnClock++;
		if (cubeClock > 23) {
			
			cubeClock = 0;
			int cubePick = Random.Range(0,9);
			CreateInstance (cubePick);
		} 
		if (yarnClock > 2) {
			yarnClock = 0;
			CreateInstance (10);
		}
		
	}
	
	private void CreateInstance(int i){
		//print (i);
		int chance = Random.Range (0, 5);
		int shieldChance = Random.Range (0,50);
		if (i == 0) { //bottom single
			Rigidbody instance = Instantiate (cubeFab, new Vector3 (10, .4f, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
			if (chance == 0) {
				Rigidbody points = Instantiate (point, new Vector3 (10, 7, cubeFab.position.z), point.rotation) as Rigidbody;
				movePoint (points);
			}
			else if(shieldChance == 0){
				Rigidbody Sinstance = Instantiate (shield, new Vector3 (10, 3.5f, shield.position.z), shield.rotation) as Rigidbody;
				movePoint (Sinstance);
			}
		} else if (i == 1) { //high single
			Rigidbody instance = Instantiate (cubeFab, new Vector3 (10, 7, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
			if (chance == 0) {
				Rigidbody points = Instantiate (point, new Vector3 (10, .4f, cubeFab.position.z), point.rotation) as Rigidbody;
				movePoint (points);
			}  else if(shieldChance == 0){
				Rigidbody Sinstance = Instantiate (shield, new Vector3 (10, 3.5f, shield.position.z), shield.rotation) as Rigidbody;
				movePoint (Sinstance);
			}
		} else if (i == 2) { //middle single
			Rigidbody instance = Instantiate (cubeFab, new Vector3 (10, 4, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance); 
			if (chance == 0) {
				int height = Random.Range (0, 1);
				if (height == 0) {
					Rigidbody points = Instantiate (point, new Vector3 (10, 7, cubeFab.position.z), point.rotation) as Rigidbody;
					movePoint (points);
				} else {
					Rigidbody points = Instantiate (point, new Vector3 (10, .4f, cubeFab.position.z), point.rotation) as Rigidbody;
					movePoint (points);
				}
			}  else if(shieldChance == 0){
				Rigidbody Sinstance = Instantiate (shield, new Vector3 (10,.4f, shield.position.z), shield.rotation) as Rigidbody;
				movePoint (Sinstance);
			}
		} else if (i == 3) {//low double
			Rigidbody instance = Instantiate (doubleCubeFab, new Vector3 (10, 2, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
		} else if (i == 4) { //high double
			Rigidbody instance = Instantiate (doubleCubeFab, new Vector3 (10, 5.5f, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
		} else if (i == 5) { // middle double
			Rigidbody instance = Instantiate (doubleCubeFab, new Vector3 (10, 3.5f, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);   
			if (chance == 0) {
				int height = Random.Range (0, 1);
				if (height == 0) {
					Rigidbody points = Instantiate (point, new Vector3 (10, 7, cubeFab.position.z), point.rotation) as Rigidbody;
					movePoint (points);
				} else {
					Rigidbody points = Instantiate (point, new Vector3 (10, .4f, cubeFab.position.z), point.rotation) as Rigidbody;
					movePoint (points);
				}
			}
			else if(shieldChance == 0){
				Rigidbody Sinstance = Instantiate (shield, new Vector3 (10, 7f, shield.position.z), shield.rotation) as Rigidbody;
				movePoint (Sinstance);
			}
			
		} else if (i == 6) { //two singles
			Rigidbody instance = Instantiate (cubeFab, new Vector3 (10, .4f, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance);
			Rigidbody instance2 = Instantiate (cubeFab, new Vector3 (10, 7, cubeFab.position.z), cubeFab.rotation) as Rigidbody;
			moveCube (instance2);
			if (chance == 0) {
				Rigidbody points = Instantiate (point, new Vector3 (10, 3.5f, cubeFab.position.z), point.rotation) as Rigidbody;
				movePoint (points);
			}
			else if(shieldChance == 0){
				Rigidbody Sinstance = Instantiate (shield, new Vector3 (10, 3.5f, shield.position.z), shield.rotation) as Rigidbody;
				movePoint (Sinstance);
			}
		} else if (i == 7) {
			Rigidbody instance = Instantiate (point, new Vector3 (10, 3.5f, cubeFab.position.z), point.rotation) as Rigidbody;
			movePoint (instance);
		} 
	}
	
	//Rigidbody instance = Instantiate (yarn, new Vector3 (sphere.position.x-.5f, sphere.position.y, sphere.position.z), yarn.rotation) as Rigidbody;
	//   if(lastYarn- sphere.position.y < .1 && lastYarn- sphere.position.y >.1 ){
	//    instance = Instantiate (yarn, new Vector3 (sphere.position.x-.5f, sphere.position.y, sphere.position.z), yarn.rotation) as Rigidbody;
	//   }else if(lastYarn > sphere.position.y){
	//    instance = Instantiate (yarn, new Vector3 (sphere.position.x-.5f, sphere.position.y, sphere.position.z), yarn.rotation) as Rigidbody;
	//    instance.transform.Rotate (new Vector3 (0, 0, -15));
	//   }
	//   else{
	//    instance = Instantiate (yarn, new Vector3 (sphere.position.x-.5f, sphere.position.y, sphere.position.z),yarn.rotation) as Rigidbody;
	//    instance.transform.Rotate (new Vector3 (0, 0, 15));
	//   }
	//lastYarn = sphere.position.y;
	//moveCube (instance);
	
	
	private void moveCube(Rigidbody cube){
		cube.AddForce (new Vector3 (-10,0,0), ForceMode.Impulse);
	}
	private void movePoint(Rigidbody point){
		point.AddForce(new Vector3(-.001f,0,0), ForceMode.Impulse);
	}
}
