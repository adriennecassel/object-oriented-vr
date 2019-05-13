using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorTimeandDistance : MonoBehaviour {

	public Camera cam;
	public GameObject Cube;
	public GameObject Group2;
	public GameObject Sphere;
	float distance;
	float start;
	float perc;
	float lenoftrans;
	float lenof1t;
	bool heldupforlongenough;
	bool iscloseforfirst;
	float end;
	float end1;
	//float fov;
	float dist;

	// Use this for initialization
	void Start () {
		Group2.GetComponent<Renderer>().material.SetColor("_Color", new Color(1f, 1f, 1f, 0f));
		perc = 0.2f;
		lenoftrans = 40f;
		lenof1t = lenoftrans * perc;
		heldupforlongenough = false;
		iscloseforfirst = false;
		//fov = 10 + ((30 - 10)*dist);
		//cam.fieldOfView = fov;
        
	}
	
	// Update is called once per frame
	void distort () {
	
		if (Time.time > end){
			return;
		}
		dist = Mathf.Clamp(((Time.time - start)/lenoftrans),0f,1f); //+ (1-((Time.time-start)/lenoftrans));
		
		//Debug.Log("time: ");
		//Debug.Log(Time.time);
		//10 to 30
		//fov = 10 + ((30 - 10) * dist);
		//cam.fieldOfView = fov;
		Group2.GetComponent<Renderer>().material.SetColor("_Color", new Color(0.3f, 0.4f, 0.6f, dist));
	}

	void Update () {
		
		distance = Vector3.Distance(Cube.transform.position, Sphere.transform.position);
 		//Debug.Log(distance);
 		
 		if (distance < 1f) { // if mirror is close
 			//Debug.Log("close");
 			if (iscloseforfirst == false) { // and also is the first time
 				//Debug.Log("GSJHSFKJGSJKGBSJKGBKJFSNG");
 				iscloseforfirst = true; // set to true
 				start = Time.time; 
 				end = start + lenoftrans;
 				end1 = start + lenof1t;
 				return;
 			}
 			if (Time.time < end) {
 				distort();
 			}
 			
 			if (Time.time > end1) {
 				heldupforlongenough = true;
 			}
 		}
 		else if (heldupforlongenough) {
 			distort();
 		}
 		else {
 			iscloseforfirst = false;
 			// undo everything that distort has done 
 			Group2.GetComponent<Renderer>().material.SetColor("_Color", new Color(1f, 1f, 1f, 0f));
 			//fov = 10;
			//cam.fieldOfView = fov;
 		}

	}// end update

}
