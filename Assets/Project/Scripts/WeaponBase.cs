using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : MonoBehaviour {

	[SerializeField] protected int damage;

	protected Cooldown attack = new Cooldown();
	protected float attackCooldown {
		get { return attackCooldown; }
		set { 
			if (value < 0)
				attack.cooldown = 0;
			else
				attack.cooldown = value;
		}
	}

	public virtual void Attack(PersonagemBase defender) {
		if (attack.isReady) {
			defender.TakeDamage (this.damage);
			attack.StartCooldown (this);
		}
	}

}