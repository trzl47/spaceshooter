using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemy;
	public bool canSpawn = true;
	public float spawnCounter = 1.0f;
	public float maxX = 28.0f;
	public float startY = 20.0f;
	float randomX;

	// Use this for initialization
	void Start () {
		StartCoroutine(spawnTimer());
	}

	// Update is called once per frame
	void Update () {
	}

	IEnumerator spawnTimer() {
		while (canSpawn == true) {
			spawnEnemy();
			yield return new WaitForSeconds(spawnCounter);
		}
	}

	void spawnEnemy() {
		randomX = Random.Range(-maxX,maxX);
		Instantiate(enemy, new Vector3(randomX,startY,0), Quaternion.identity);
	}
}
