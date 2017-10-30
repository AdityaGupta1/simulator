using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour {
	void OnTriggerEnter (Collider other) {
		if (other.gameObject.tag == "Warp Start") {
			transform.position = other.GetComponent<WarpTarget>().target.position;
		}
	}﻿
}
