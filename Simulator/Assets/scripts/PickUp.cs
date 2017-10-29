using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour 
{
	public Transform target;
	Rigidbody body;

	void Start()
	{
		body = gameObject.GetComponent<Rigidbody> ();
	}

	void OnMouseDown()
	{
		this.transform.position = target.position;
		this.transform.parent = GameObject.Find("FPSController").transform;
		this.transform.parent = GameObject.Find("FirstPersonCharacter").transform;
		body.isKinematic = true;
	}

	void OnMouseUp()
	{
		this.transform.parent = GameObject.Find("FPSController").transform;
		this.transform.parent = null;
		body.isKinematic = false;
	}

}﻿