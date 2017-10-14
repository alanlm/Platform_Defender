using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.CompareTag ("Player"))
			return; 
		
		gameObject.SetActive (false); 
	}
}
