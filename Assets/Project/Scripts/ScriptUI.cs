using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScriptUI : MonoBehaviour {

	public Slider healthBar;
	public Text waveText;
//	public Spawner waves;

	private BaseCharacter player;
	private float playerMaxHealth;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag ("Player").GetComponent<BaseCharacter> ();
		playerMaxHealth = player.health;
	}
	
	// Update is called once per frame
	void Update () {
		if (player != null)
			AtualizaVida ();
	}

	private void AtualizaVida() {
		healthBar.value = player.health / playerMaxHealth;
	}

	public void AtualizaWave(int wave) {
		waveText.text = "Wave: " + wave.ToString ();
	}
}
