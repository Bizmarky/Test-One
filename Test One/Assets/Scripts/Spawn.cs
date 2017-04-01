using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	GameObject alive;

	// Use this for initialization
	void Start () {
		alive = GameObject.Find ("Player");
		alive.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) 
		{
			alive.SetActive (true);
		}
		if (Input.GetKeyDown ("backspace")) 
		{
			alive.SetActive (false);
		}
	}
}
