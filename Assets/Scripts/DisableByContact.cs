using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableByContact : MonoBehaviour {

	void OnTriggerEnter(Collider other) 
	{
		if (other.CompareTag ("Player") || other.CompareTag("Platform"))
			return; 
		
		gameObject.SetActive (false); 
	}
}
