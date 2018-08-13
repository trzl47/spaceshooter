using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLogic : MonoBehaviour {

	public float transformSpeed = 0.5f;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		transformToTop();

	}

	void transformToTop() {
		transform.Translate(0,transformSpeed,0);
	}

}
