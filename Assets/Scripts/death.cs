using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class death : MonoBehaviour {

	private GameObject target;
 
	private void Start()
	{
		target = GameObject.FindWithTag("Player");
	}
 

	private void OnTriggerEnter(Collider other)
	{
		target.transform.position = new Vector3(-30f, -5f, -8f);
		gameOver();
	
	}

	private void gameOver()
	{
		
		GameObject.FindObjectOfType<Canvas>().enabled = true;
		Time.timeScale = 0;
	}
}
