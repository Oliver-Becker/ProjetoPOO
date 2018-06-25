using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class PersonagemBase : MonoBehaviour {
	
	[SerializeField] protected int health;
	[SerializeField] protected int speed;

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
	protected bool canAttack;

	public virtual void TakeDamage(int damage){
		if (immunity.isReady) {
			this.health -= damage;
			immunity.StartCooldown (this);
		}
	}

	public abstract void Move ();
}
