using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByBoudary : MonoBehaviour {

	void OnTriggerExit(Collider other)
	{
		if (tag == "Hazard") {
			GameObject p = GameObject.Find ("Player");
			PlayerController play = p.GetComponent<PlayerController> ();
			play.comptBall -= 3;
		}
		Destroy(other.gameObject);
	}
}
