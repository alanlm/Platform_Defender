using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour {

	public float platformSpeed; 

	void Update () {
		transform.position = new Vector3 (Time.time * platformSpeed, 0f, 0f); 
	}
}
