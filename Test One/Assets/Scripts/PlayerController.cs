using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;

	//Speed variable for cube movement
	private float speed = 20f;

	//Color variable and renderer for the color of the cube
	public Color color;
	public Renderer rend;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();

		//Assign the color variable and the renderer
		color = gameObject.GetComponent<Renderer> ().material.color;
		rend = GetComponent<Renderer> ();
		rend.material.color = color;
	}
	
	// Update is called once per frame
	void Update () {
		
		//Gets input from the arrow keys and moves the cube
		float horizontal = Input.GetAxis ("Horizontal");
		float vertical = Input.GetAxis ("Vertical");

		Vector3 move = new Vector3 (horizontal, 0, vertical);
		rb.AddForce (move * speed);



		//The following are buttons 1, 2, 3 corresponding to yellow, blue, green
		if (Input.GetKeyDown ("1")) 
		{
			color = Color.yellow;
		}		
		if (Input.GetKeyDown ("2")) 
		{
			color = Color.blue;
		}
		if (Input.GetKeyDown ("3")) 
		{
			color = Color.green;
		}
		rend.material.color = color;
	}
}
