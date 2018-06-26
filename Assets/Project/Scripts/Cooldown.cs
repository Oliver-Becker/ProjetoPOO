using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cooldown {

	public float time;

	public bool isReady {
		get; private set;
	}

	public Cooldown() {
		this.time = 0;
		this.isReady = true;
	}

	public Cooldown(float time) {
		this.time = time;
		this.isReady = true;
	}

	public void StartCooldown(MonoBehaviour caller) {
		caller.StartCoroutine (WaitCooldown ());
	}

	private IEnumerator WaitCooldown() {
		isReady = false;
		yield return new WaitForSeconds (time);
		isReady = true;
	}
}