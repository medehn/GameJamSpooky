using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;

public class WinGameTrigger : MonoBehaviour {


	public Image overlay;
	public Text endGame;
	public Text credits;
	private bool teddy;
	
	private GameObject target;
 

	// Use this for initialization
	void Start ()
	{
		overlay.enabled = false;
		endGame.enabled = false;
		credits.enabled = false;
		target = GameObject.FindWithTag("Player");

	}
	
	// Update is called once per frame
	void Update () {
		
	}


	private void OnTriggerEnter(Collider other)
	{

		if (GameObject.Find("ghost").GetComponent<PlayerScript>().has_teddy == true)
		{
			overlay.enabled = true;
			endGame.enabled = true;
			credits.enabled = true;
			Time.timeScale = 0;
		}
	}
}
