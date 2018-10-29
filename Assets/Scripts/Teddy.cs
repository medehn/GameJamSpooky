using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teddy : MonoBehaviour {
	
	private GameObject target;
	public Rigidbody rb;
	

	// Use this for initialization
	void Start () {
		target = GameObject.FindWithTag("Player");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		
		Vector3 pos1 = target.transform.position;
		rb.position = pos1;
	}
}
