using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedEnemy : BaseEnemy {

	public GameObject bullet;
	// Use this for initialization
	void Start () {
		immunityCooldown = 0.2f;
		enemyCounter++;
		health = 10;
		damage = 2;
		playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if(attack.isReady && playerTransform != null){
			GameObject spawned = Instantiate(bullet, transform.position, Quaternion.identity);
			spawned.GetComponent<Projectile>().Shoot(playerTransform.position, "Player", damage);
			attack.StartCooldown(this);
		}	
	}

	public void OnDestroy() {
		enemyCounter--;
	}
}
