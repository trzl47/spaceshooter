using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTransform : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D transformCollision) {
		if (transformCollision.gameObject.tag == "Collision") {
			Destroy (transformCollision.gameObject);
		}

	}
}