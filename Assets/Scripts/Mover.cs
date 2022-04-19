using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
	public float speed;
	private Rigidbody rb;

	Ray rayMouse;


	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		rayMouse = Camera.main.ScreenPointToRay(Input.mousePosition);
		rb.velocity = rayMouse.direction * speed;
	
	}
}
