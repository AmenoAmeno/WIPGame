using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	public GameObject character;
	public float speed;
	// Use this for initialization
	void Start () {
		speed = 6.0f;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey(KeyCode.D)){
			character.transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.A)){
			character.transform.position += Vector3.left* speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.W)){
			character.transform.position += Vector3.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.S)){
			character.transform.position += Vector3.back* speed * Time.deltaTime;
		}
	}
}
