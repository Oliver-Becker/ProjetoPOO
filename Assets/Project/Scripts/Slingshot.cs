using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slingshot : WeaponBase {

	public GameObject ammunition;

	// Use this for initialization
	void Start () {
		attackCooldown = 0.5f;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButton (0))
			Attack ();
	}

	public void Attack() {
		if (attack.isReady) {
			Vector3 destination = Input.mousePosition;
			destination.z = 10.0f;
			destination = Camera.main.ScreenToWorldPoint (destination);
			GameObject spawned = Instantiate(ammunition, transform.position, Quaternion.identity);
			spawned.GetComponent<Projectile>().Shoot(destination, "Enemy", damage);
			attack.StartCooldown(this);
		}
	}
}