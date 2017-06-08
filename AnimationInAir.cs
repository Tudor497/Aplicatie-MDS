using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class AnimationInAir : MonoBehaviour {

	private Animator animator;
	public bool inAir;
	void Start()
	{
		animator = GetComponent<Animator>();
		inAir = true;
		animator.SetBool ("inAir", inAir);
	}

	void Update()
	{
		

			

	}
	void OnCollisionEnter2D (Collision2D  col)
	{
		
		inAir = false;
		animator.SetBool ("inAir", false);
		animator.SetBool ("inAir", true);


	}

}
