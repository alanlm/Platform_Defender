﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickToPlatform : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Player"))
			other.transform.SetParent (transform); 
	}

	void OnTriggerExit(Collider other)
	{
		other.transform.SetParent (null); 
	}
}
