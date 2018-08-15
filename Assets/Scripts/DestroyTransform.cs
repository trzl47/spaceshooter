using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTransform : MonoBehaviour {

	public GameObject explosion;
	void OnCollisionEnter2D(Collision2D transformCollision) {
		spawnExplosion(transformCollision.transform.position);

		if (transformCollision.gameObject.tag == "Collision") {
			Destroy (transformCollision.gameObject);
			GameObject.FindGameObjectWithTag("GUI").GetComponent<ScoreLogic>().addToScoreVOID();
		}

		if (transformCollision.gameObject.tag == "Projectile") {
			Destroy (transformCollision.gameObject);
		}
	}

	void spawnExplosion(Vector2 tempPosition) {
		Instantiate(explosion, tempPosition, Quaternion.identity);
	}
}