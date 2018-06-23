using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponBase : MonoBehaviour {

	protected int damage;

	// Use this for initialization
	void Start () {
//		Attack (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
//		Attack (gameObject);
	}

	public virtual void Attack(PersonagemBase defender) {
		defender.TakeDamage (this.damage);
	}
}