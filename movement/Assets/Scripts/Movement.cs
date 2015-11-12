using UnityEngine;
using System.Collections;

[DisallowMultipleComponent]
[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
public class Movement : MonoBehaviour 
{
	Animator anim;

	bool isWalking = false;

	void Awake()
	{
		anim = GetComponent<Animator> ();
	}


	void Update()
	{
		//turning
		//jumping
		Walking();
		Move();
	}



	void Walking()
	{
		if(Input.GetKeyDown(KeyCode.CapsLock))
		{
			isWalking = !isWalking;
			anim.SetBool ("Walk", isWalking);
		}
	}
	void Move()
	{
		
		if(Input.GetKeyDown(KeyCode.LeftShift))
			anim.SetBool ("Walk", true);
		if(Input.GetKeyUp(KeyCode.LeftShift))
			anim.SetBool ("Walk", false);
		anim.SetFloat("Forward", Input.GetAxis("Vertical"));
	}



}
