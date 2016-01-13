﻿using UnityEngine;
using System.Collections;

public class Lizard : MonoBehaviour {

	private Animator animator;
	private Attacker attacker;
	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();
		attacker = GetComponent<Attacker> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		GameObject obj = collider.gameObject;

		if (!obj.GetComponent<Defender> ()) {
			return;
		}

		if (obj.GetComponent<Defender> ()) {
			animator.SetBool ("isAttacking", true);
			attacker.Attack(obj);
		}
	}
}
