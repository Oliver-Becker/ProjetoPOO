using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoMeele : InimigoBase {

	private PlayerController playerStats;
	// Use this for initialization
	void Start () {
		playerTransform = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		playerStats = playerTransform.GetComponent<PlayerController>();
		rb = gameObject.GetComponent<Rigidbody2D>();
		speed = 5;
		damage=3;


	}
	
	// Update is called once per frame
	void Update () {
		Move();
	}
}
