using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : WeaponBase {
	protected string enemy;

	protected int speed = 6;

	// Use this for initialization
	void Start () {
		
	}

	public void Shoot(Vector3 player, string s, int damage){
		Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
		Vector3 direction;
		direction = player - transform.position;
		direction = direction.normalized * this.speed;
		rb.velocity = (Vector2)direction;
		this.enemy = s;
		this.damage = damage;
	}

	void OnTriggerEnter2D(Collider2D collisionInfo){

        //If the object we collided with was a Runner and not a Catcher.
        if (collisionInfo.gameObject.tag == this.enemy){
			collisionInfo.gameObject.GetComponent<PersonagemBase>().TakeDamage(this.damage);
			Destroy(gameObject);
        }
    }
}
