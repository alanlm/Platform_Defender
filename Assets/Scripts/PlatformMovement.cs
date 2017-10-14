using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {

	public float platformSpeed; 

	void Update () {
		// get the edges of the platform 
		float rightEdge = transform.position.x + (transform.childCount / 2) + 0.5f; 
		float leftEdge = transform.position.x - (transform.childCount / 2) + 0.5f;  

		Debug.Log ("Right Edge: " + rightEdge); 
		Debug.Log ("Left Edge: " + leftEdge); 

		// calculate boundary of platform 
		float angle = Camera.main.fieldOfView * Mathf.Deg2Rad; 
		float distToCamera = Camera.main.transform.position.z; 
		float boundary = Mathf.Abs(distToCamera) * Mathf.Tan (angle); 

		// if platform edges reach camera's boundary 
		if (rightEdge >= Mathf.Floor (boundary) || leftEdge <= Mathf.Floor (-boundary))
			platformSpeed = -platformSpeed; 
		
		transform.Translate(Time.deltaTime * platformSpeed, 0f, 0f); 
	}
}
