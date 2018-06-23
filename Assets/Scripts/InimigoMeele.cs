using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoMeele : InimigoBase {
	// Use this for initialization
	void Start () {
		playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		rb = gameObject.GetComponent<Rigidbody2D>();
		damage=3;
	}	
	// Update is called once per frame
	void Update () {
			Move();
	}
	public void OnCollisionStay2D(Collision2D collisionInfo){
		if(collisionInfo.gameObject.tag == "Player") {
			collisionInfo.gameObject.GetComponent<PlayerController>().TakeDamage(damage);
		}
	}
}
