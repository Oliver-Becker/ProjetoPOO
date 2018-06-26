using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoBase : PersonagemBase {
	[SerializeField] protected int damage;
	protected Transform playerTransform;
	protected Rigidbody2D rb;

	protected Cooldown attack = new Cooldown(1);
	protected float attackCooldown {
		get { return attackCooldown; }
		set { 
			if (value < 0)
				attack.cooldown = 0;
			else
				attack.cooldown = value;
		}
	}

	public override void Move(){
		//if(canMove == true){//Movimenta o inimigo(variavel da classe base) 
			Vector3 direction;
			direction = playerTransform.position - transform.position;
			direction = direction.normalized * speed;
			rb.velocity = (Vector2)direction;
		
	}
}
