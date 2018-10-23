using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorTiltScript : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () 
	{	
		anim = GetComponent<Animator>();
		//vagmirror = GameObject.Find("vagmirror");
	}
	// Update is called once per frame
	void Update () 
	{
	if (Input.GetMouseButtonDown(0)) 
		{

			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit, 300.0f))
			{
				if (hit.transform != null)
				{
					PrintName(hit.transform.gameObject);

					if (hit.transform.gameObject.name == "vagmirror") 
					{
						Debug.Log("anim");
						anim.SetTrigger("TriggerAnim");
					}
				}
			}
		}

	}

	private void PrintName(GameObject go)
	{
		print(go.name);
	}
}
