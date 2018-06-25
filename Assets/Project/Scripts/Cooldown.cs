using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class CoRotina : MonoBehaviour {
	public static CoRotina instance;

	void Start() {
		CoRotina.instance = this;
	}
}
*/
public class Cooldown {

	public float cooldown;

	public bool isReady {
		get; private set;
	}

	public Cooldown() {
		this.cooldown = 0;
		this.isReady = true;
	}

	public Cooldown(float cooldown) {
		this.cooldown = cooldown;
		this.isReady = true;
	}

	public void StartCooldown(MonoBehaviour caller) {
		caller.StartCoroutine (WaitCooldown ());
	}

	private IEnumerator WaitCooldown() {
		isReady = false;
		yield return new WaitForSeconds (cooldown);
		isReady = true;
	}
}