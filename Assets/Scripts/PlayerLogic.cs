using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour {

	public GameObject projectile;
	public float xRotation = 1.0f;
	public float yRotation = 1.0f;
	public float zRotation = 1.0f;
	public float playerSpeed = 1.0f;
	public float moveBoundary = 29.0f;
	public float shotSpeed = 0.8f;
	public bool shooting = true;

	// Use this for initialization
	void Start () {
		StartCoroutine(shootTimer());
	}

	// Update is called once per frame
	void Update () {
		playerControls();
	}

	void playerControls() {
		playerMovement();
	}

	void playerMovement() {
		if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && transform.position.y <= moveBoundary) {
			transform.Translate(0,playerSpeed,0);
		}
		if ((Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) && transform.position.x >= -moveBoundary) {
			transform.Translate(-playerSpeed,0,0);
		}
		if ((Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) && transform.position.y >= -moveBoundary) {
			transform.Translate(0,-playerSpeed,0);
		}
		if ((Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) && transform.position.x <= moveBoundary) {
			transform.Translate(playerSpeed,0,0);
		}
	}

	IEnumerator shootTimer() {
		while (shooting == true) {
			spawnProjectile();
			yield return new WaitForSeconds(shotSpeed);
		}
	}

	void spawnProjectile() {
		Instantiate(projectile, transform.position, Quaternion.identity);
	}

	void rotateTheTransform() {
			transform.Rotate(xRotation,yRotation,zRotation);
	}
}
