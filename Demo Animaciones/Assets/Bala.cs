using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bala : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		Rigidbody rgb = GetComponent<Rigidbody>();
		rgb.AddForce(400 * Vector2.one);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
