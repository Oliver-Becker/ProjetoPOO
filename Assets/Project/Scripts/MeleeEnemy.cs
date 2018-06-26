using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeEnemy : BaseEnemy {
	// Use this for initialization
	void Start () {
		immunityCooldown = 0.2f;
		enemyCounter++;
		health = 15;
		playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		rb = gameObject.GetComponent<Rigidbody2D>();
		attackCooldown = 0.3f;
	}	
	// Update is called once per frame
	void Update () {
		if (playerTransform != null)
			Move ();
	}
	public void OnCollisionStay2D(Collision2D collisionInfo){
		if(collisionInfo.gameObject.tag == "Player") {
			if(attack.isReady){
				collisionInfo.gameObject.GetComponent<PlayerController>().TakeDamage(damage);
				attack.StartCooldown (this);
				
			}
		}
	}

	public void OnDestroy() {
		enemyCounter--;
	}
}
