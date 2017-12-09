﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IniciarScript : MonoBehaviour {
	public Text txtPontos;

	void Start(){
		FlappyBirdScript.inGame = false;
	}

	
	// Update is called once per frame
	void Update () {
		txtPontos.text = PrincipalScript.pontos.ToString ();


		if(Input.GetKey(KeyCode.Return) || Input.touchCount == 2){
			PrincipalScript.pontos = 0;
			SceneManager.LoadScene ("game");
		}
		
	}
}
