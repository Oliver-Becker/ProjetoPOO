using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public int initialEnemies;
	public float spawnColdown;
	public GameObject[] enemies;

	private Cooldown cooldown;
	private bool spawned = true;
	private int wave = 0;

	// Use this for initialization
	void Start () {
		cooldown = new Cooldown (spawnColdown);
	}
	
	// Update is called once per frame
	void Update () {
		if (BaseEnemy.enemyCounter == 0) {
			if (spawned) {
				cooldown.StartCooldown (this);
				spawned = false;
			} else if (cooldown.isReady) {
				wave++;
				spawned = true;
				SpawnEnemy (initialEnemies + (int)Mathf.Sqrt(wave));
			}
		}
	}

	private Vector3 GenerateRandomLocation() {
		float height = 4.5f;
		float lenght = 8.5f;

		return new Vector3 (Random.Range (-lenght, lenght), Random.Range (-height, height), 0.0f);
	}

	private void SpawnEnemy(GameObject enemy, Vector3 location) {
		Instantiate (enemy, location, Quaternion.identity);
	}

	private void SpawnEnemy(int numberOfEnemies) {
		if (enemies == null || enemies.Length == 0)
			return;
		
		int maxIndex = enemies.Length;
		for (int i = 0; i < numberOfEnemies; ++i) {
			SpawnEnemy (enemies [Random.Range (0, maxIndex)], GenerateRandomLocation());
		}
	}
}
