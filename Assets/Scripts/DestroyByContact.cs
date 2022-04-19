using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {


	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Boundary")
		{
			return;
		}
		else if (other.tag == "Ball"){
			if (tag == "Bonus") {
				GameObject p = GameObject.Find ("Player");
				PlayerController play = p.GetComponent<PlayerController> ();
				play.comptBall += 5;
			}
		}
		Destroy(gameObject);
	}
}
