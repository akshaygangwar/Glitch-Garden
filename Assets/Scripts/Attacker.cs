﻿using UnityEngine;
using System.Collections;

public class Attacker : MonoBehaviour {

	private float currentSpeed;
	private GameObject currentTarget;
	// Use this for initialization
	void Start () {
		//Rigidbody2D myRigidbody = gameObject.AddComponent<Rigidbody2D> ();
		//myRigidbody.isKinematic = true;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * currentSpeed * Time.deltaTime);
	}

	void OnTriggerEnter2D()
	{
		//Debug.Log (name + " trigger enter");
	}

	public void SetSpeed(float speed){
		currentSpeed = speed;
	}

	public void StrikeCurrentTarget(float damage){
		Debug.Log (name + " caused damage: " + damage.ToString ());
	}

	public void Attack(GameObject obj){
		currentTarget = obj;
	}
}
