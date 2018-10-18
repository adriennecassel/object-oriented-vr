using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour 
{
	//public ParticleSystem Event;
	public GameObject Event;
	
	void OnCollisionEnter (Collision coll) {
		if (coll.collider.CompareTag("Bowl")) {
			Event.GetComponent<ParticleSystem>().Play();
			
			//Particles();
		}
	}

	// void Particles () {
	// 	GameObject Event = Instantiate (Event, position, Quaternion.identity);
	// 	Event.GetComponent<ParticleSystem>().Play();
	// }

	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("Entered trigger");
		Renderer rend = GetComponent<Renderer>();

		//rend.material.shader = Shader.Find("_Color");
		rend.material.SetColor("_Color", Color.blue);
	}
	void OnTriggerStay (Collider other)
	{
		Debug.Log ("within trigger");
	}
	void OnTriggerExit (Collider other)
	{
		Debug.Log ("exited trigger");
		Event.GetComponent<ParticleSystem>().Stop();

	}
}