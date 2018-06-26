using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoMeele : InimigoBase {
	// Use this for initialization
	void Start () {
		health = 15;
		playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		rb = gameObject.GetComponent<Rigidbody2D>();
		attackCooldown = 0.3f;
	}	
	// Update is called once per frame
	void Update () {
		Move();
	}
	public void OnCollisionStay2D(Collision2D collisionInfo){
		if(collisionInfo.gameObject.tag == "Player") {
			if(attack.isReady){
				collisionInfo.gameObject.GetComponent<PlayerController>().TakeDamage(damage);
				attack.StartCooldown (this);
				
			}
		}
	}
}
