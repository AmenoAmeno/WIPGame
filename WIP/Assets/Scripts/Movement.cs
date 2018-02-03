using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public GameObject character;

	public float speed;
	public float jumpSpeed;
	// Use this for initialization
	void Start () {
		//start speed of the Char
		speed = 4.0f;
		jumpSpeed = 5.0f;
	}
	
	// Update is called once per frame
	void Update () {
		//gets the input from D to move the Char to the RIGHT
		if (Input.GetKey(KeyCode.D)){
			character.transform.position += Vector3.right * speed * Time.deltaTime;
		}
		//gets the input from A to move the Char to the LEFT
		if (Input.GetKey(KeyCode.A)){
			character.transform.position += Vector3.left* speed * Time.deltaTime;
		}
		//gets the input from W to move the Char UP
		if (Input.GetKey(KeyCode.W)){
			character.transform.position += Vector3.forward * speed * Time.deltaTime;
		}
		//gets the input from S to move the Char DOWN
		if (Input.GetKey(KeyCode.S)){
			character.transform.position += Vector3.back* speed * Time.deltaTime;
		}
		if (Input.GetKey (KeyCode.Space)) {
			character.transform.position += Vector3.up* jumpSpeed* Time.deltaTime;
		}
	}
	void FixedUpdate(){
		
	}
}
