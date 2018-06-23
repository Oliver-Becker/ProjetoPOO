using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class PersonagemBase : MonoBehaviour {
	
	[SerializeField] protected int health;
	[SerializeField] protected int speed;
	[SerializeField] protected float immunityCooldown;

	protected bool canMove;
	private bool isImmune = false;

	public virtual void TakeDamage(int damage){
		if (!isImmune) {
			this.health -= damage;
			StartCoroutine (WaitForImmunity ());
		}
	}

	private IEnumerator WaitForImmunity() {
		isImmune = true;
		yield return new WaitForSeconds (immunityCooldown);
		isImmune = false;
	}

	public abstract void Move ();


}
