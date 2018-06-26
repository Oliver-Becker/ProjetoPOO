using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class PersonagemBase : MonoBehaviour {
	
	[SerializeField] protected int health;
	[SerializeField] protected float speed;

	private Cooldown immunity = new Cooldown(1);

	protected float immunityCooldown {
		get { return immunityCooldown; }
		set { 
			if (value < 0)
				immunity.cooldown = 0;
			else
				immunity.cooldown = value;
		}
	}
			
	protected bool canMove;

	public virtual void TakeDamage(int damage){
		if (immunity.isReady) {
			this.health -= damage;
			if (this.health <= 0)
				Destroy (gameObject);
			immunity.StartCooldown (this);
		}
	}

	public abstract void Move ();
}
