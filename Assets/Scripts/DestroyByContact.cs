﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		gameObject.SetActive (false); 
	}
}