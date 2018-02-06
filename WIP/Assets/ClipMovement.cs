using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClipMovement : MonoBehaviour {
	public GameObject Char;
	public GameObject WayPoint;

	public float Speed;
	Vector3 targetPosition;

	void Start () {

		targetPosition = transform.position;
		Speed = 3.0f;
	}
	void Update ()
	{
		//float step = Speed * Time.deltaTime;

		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit)) {
				targetPosition = hit.point;
				WayPoint.transform.position = targetPosition;
				Char.transform.position = Vector3.Lerp (transform.position, targetPosition, Speed);
			}
		}
	}
}