using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {

	public float platformSpeed; 

	float offset; 

	void Start() { 
		// calculate platform offset 
		offset = (transform.childCount / 2) + 1.5f; 
	}

	void Update () {
		// get the edges of the platform 
		float rightEdge = transform.position.x + offset; 
		float leftEdge = transform.position.x - offset; 

		// if platform edges reach camera's boundaries, reverse direction 
		if(Camera.main.WorldToScreenPoint(new Vector3(leftEdge, 0f, 0f)).x <= 0 
			|| Camera.main.WorldToScreenPoint(new Vector3(rightEdge, 0f, 0f)).x >= Screen.width)
			platformSpeed = -platformSpeed; 

		// move platform 
		transform.Translate(Time.deltaTime * platformSpeed, 0f, 0f); 
	}
}
