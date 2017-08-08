using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Personagem : MonoBehaviour {

	public float velocidade;
	Animator animator;

	void Start () {
		animator = GetComponent<Animator> ();
	}
	
	void Update () {
		float px = CrossPlatformInputManager.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;
		float py = CrossPlatformInputManager.GetAxisRaw ("Vertical") * velocidade * Time.deltaTime;
		transform.Translate (px, py, 0.0f);

		animator.SetFloat ("pHorizontal", CrossPlatformInputManager.GetAxisRaw("Horizontal"));
		animator.SetFloat ("pVertical", CrossPlatformInputManager.GetAxisRaw("Vertical"));
	}
}
