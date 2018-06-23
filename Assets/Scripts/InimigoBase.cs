using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoBase : PersonagemBase {
	protected int damage;
	protected Transform playerTransform;
	protected Rigidbody2D rb;

	public override void Move(){
		//if(canMove == 1)//Movimenta o inimigo(variavel da classe base) 
			Vector3 direction;
			direction = playerTransform.position - transform.position;
			direction = direction.normalized * speed;
			rb.velocity = (Vector2)direction;
	}

}
