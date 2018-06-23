using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class PersonagemBase : MonoBehaviour {
	
	[SerializeField] protected int health;
	[SerializeField] protected int speed;
	[SerializeField] protected float imunityCooldown;

	protected bool canMove;

	private float imunityCounter;

	void Start() {
		imunityCounter = 0;
	}

	void Update() {
		if (imunityCounter < imunityCooldown)
			imunityCounter += Time.deltaTime;
	}

	protected float GetImunityCounter() {
		return imunityCounter;
	}

	public virtual void TakeDamage(int damage){
		if (imunityCounter >= imunityCooldown) {
			this.health -= damage;
			imunityCounter = 0;
		}
	}

	public abstract void Move ();
}
