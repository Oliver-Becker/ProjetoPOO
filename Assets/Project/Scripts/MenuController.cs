using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	public void ChangeScene(string scene) {
		SceneManager.LoadScene (scene);
	}

	public void ExitGame() {
		Debug.Log ("Fechando o jogo!");
		Application.Quit ();
	}
}
