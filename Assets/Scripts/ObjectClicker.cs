using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClicker : MonoBehaviour {

	public float force = 5;
	public GameObject go;

	private void Update()
	{
		Cursor.visible = true;
		
		if (Input.GetMouseButtonDown(0)) 
		{

			RaycastHit hit;
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

			if (Physics.Raycast(ray, out hit, 300.0f))
			{
				if (hit.transform != null)
				{
					PrintName(hit.transform.gameObject);

					if (hit.transform.gameObject.name == "Bowl") 
					{
						//Debug.Log("BowlColor");
						//go.Find("Bowl");
						//go.transform.position = new Vector3(1, 1, 1);
						// Renderer rend = GetComponent<Renderer>();
						// rend.material.SetColor("_Color", Color.blue);
					}

					if (hit.transform.gameObject.name == "vagmirror")
					{
						//Animator anim;
						/*GameObject vagmirror;

						vagmirror = GameObject.Find("vagmirror");*/
						//anim = GetComponent<Animator>();
						//anim.SetTrigger("TriggerAnim");

						//GetComponent<Animator>().Play;

						//float speed = 1F;
						//vagmirror.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 180), Time.deltaTime * speed);
						//vagmirror.transform.Rotate(90, 0, 0);
						//vagmirror.transform()						
					} 

					Rigidbody rb;

					if (rb = hit.transform.GetComponent<Rigidbody>())
					{
						
						LaunchIntoAir(rb);
						//offset = (Input.mousePosition - Camera.main.ScreenPointToRay((Input.mousePosition.x, Input.mousePosition.y, transform.position.z));
					}
				}
			}
		}
	}

	private void PrintName(GameObject go)
	{
		print(go.name);
	}

	private void LaunchIntoAir(Rigidbody rig)
	{
		rig.AddForce(rig.transform.up * force, ForceMode.Impulse);
	}

	private void OnMouseDown()
	{
		transform.Rotate(0, 0, 180);
	}

}