using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoScript : MonoBehaviour {
	public float velocidade;
	public float alturaInicial, alturaFinal;
	public float limiteX;

	// Update is called once per frame
	void Update () {

		if (FlappyBirdScript.inGame) {
			//move o cano
			transform.Translate (Vector2.left * velocidade * Time.deltaTime);

			//verifica o limite e retorna ao cano
			if (transform.position.x <= limiteX) {
				transform.position = new Vector2 (limiteX * -1, Random.Range (alturaInicial, alturaFinal));

			}
		}
	}
}
