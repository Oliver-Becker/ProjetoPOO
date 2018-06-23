using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PersonagemBase {

	private Rigidbody2D rigid;

	// Use this for initialization
	void Start () {
		rigid = gameObject.GetComponent<Rigidbody2D> ();
		if (rigid == null)
			Debug.Log ("ERRO! Não existe Rigidbody2D neste GameObject");

		canMove = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (canMove)
			Move ();

	}

	public override void Move() {
		//Debug.Log ("movendo");
		float horizontalMovement = Input.GetAxisRaw ("Horizontal");
		float verticalMovement = Input.GetAxisRaw ("Vertical");
		Vector2 movement = new Vector2 (horizontalMovement, verticalMovement);

		rigid.velocity = movement.normalized * speed;
	}
}
