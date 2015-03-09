using UnityEngine;
using System.Collections;

public class WallCollision : MonoBehaviour {

	void OnCollisionEnter(Collision col){
			Destroy(col.gameObject);
	}
}
