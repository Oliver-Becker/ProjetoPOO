using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoRanged : InimigoBase {

	
	public GameObject bullet;
	// Use this for initialization
	void Start () {
		health = 10;
		damage = 2;
		playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		if(attack.isReady){
			GameObject spawned = Instantiate(bullet, transform.position, Quaternion.identity);
			spawned.GetComponent<Projectile>().Shoot(playerTransform.position, "Player", damage);
			attack.StartCooldown(this);
		}	
	}
}
