using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : MonoBehaviour {

	[SerializeField] protected int damage;
	protected int ammunition;

	public virtual void Attack(PersonagemBase defender) {
		defender.TakeDamage (this.damage);
	}
}