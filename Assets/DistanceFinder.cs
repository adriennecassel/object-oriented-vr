using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceFinder : MonoBehaviour 
{
	public GameObject Cube;
	public GameObject Sphere;
	public float Distance_;
    
    void Start() {

 	}     

 	void Update () {
 		Distance_ = Vector3.Distance(Cube.transform.position, Sphere.transform.position);
 		Debug.Log(Distance_);
 		if (Distance_ < 0.6) {
 			Debug.Log("ALERT");
 		}
 	
 	}
}
