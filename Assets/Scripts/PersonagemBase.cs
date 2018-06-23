using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PersonagemBase : MonoBehaviour {
	protected int vida;
	protected int velocidade;
	

	public virtual void PerdeVida(int dano){
		this.vida -= dano;
	}
	public abstract void Move();
}
