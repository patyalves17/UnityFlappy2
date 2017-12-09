using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBirdScript : MonoBehaviour {
	public float impulso;
	Rigidbody2D rb;
	public static bool inGame;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.gravityScale = 0.0f;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!inGame && Input.GetButtonDown("Fire1")){
			inGame = true;
			rb.gravityScale = 1.0f;
		}else if(inGame && Input.GetButtonDown("Fire1")){
			rb.velocity = new Vector2 (0.0f, impulso);
		}
	}

	//detecta colisao com trigger
	void OnTriggerEnter2D(Collider2D c){
		//print (c.tag);
		PrincipalScript.pontos++;
		print (PrincipalScript.pontos);
	}

	void OnTriggerStay2D(Collider2D c){}
	void OnTriggerExit2D(Collider2D c){}

	void OnCollisionEnter2D(Collision2D c){
		SceneManager.LoadScene ("Start");
	}

}
