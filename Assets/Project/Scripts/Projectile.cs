using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : WeaponBase {
	protected string target;

	protected float speed = 6;

	public void Shoot(Vector3 targetPosition, string targetTag, int damage){
		Rigidbody2D rb = gameObject.GetComponent<Rigidbody2D>();
		Vector3 direction;
		direction = targetPosition - transform.position;
		direction = direction.normalized * this.speed;
		rb.velocity = (Vector2)direction;
		this.target = targetTag;
		this.damage = damage;
	}

	void OnTriggerEnter2D(Collider2D collisionInfo) {
		Debug.Log ("collider tag: " + collisionInfo.gameObject.tag +"target: " + target);
        if (collisionInfo.gameObject.tag == this.target){
			collisionInfo.gameObject.GetComponent<PersonagemBase>().TakeDamage(this.damage);
			Destroy(gameObject);
        }
    }
}
