using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class BaseCharacter : MonoBehaviour {
	
	[SerializeField] public int health;
	[SerializeField] protected float speed;

	private Cooldown immunity = new Cooldown(1);

	protected float immunityCooldown {
		get { return immunityCooldown; }
		set { 
			if (value < 0)
				immunity.time = 0;
			else
				immunity.time = value;
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
