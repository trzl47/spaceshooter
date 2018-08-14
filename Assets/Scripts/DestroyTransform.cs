using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTransform : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D transformCollision) {
		if (transformCollision.gameObject.tag == "Collision") {
			Destroy (transformCollision.gameObject);
			GameObject.FindGameObjectWithTag("GUI").GetComponent<ScoreLogic>().addToScoreVOID();
		}

		if (transformCollision.gameObject.tag == "Projectile") {
			Destroy (transformCollision.gameObject);
		}
	}
}