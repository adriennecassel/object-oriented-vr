using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RippleAnim : MonoBehaviour {

	public Animator animator;
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Tab)) 
		{
			animator.SetTrigger("SetTransition");
		}
		
	}
}
