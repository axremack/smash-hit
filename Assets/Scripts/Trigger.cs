using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour {

	public Transform door;
	public GameObject Door;
	private bool opening;
	public Vector3 spawnValues;

	private Renderer bouton;

	void Start (){
		bouton = GetComponent<Renderer> ();
		opening = false;
	}
		
	void Update () {
		if (opening) {
			OpenDoor ();
			bouton.material.shader = Shader.Find ("_Color");
			bouton.material.SetColor ("_Color", Color.green);
			bouton.material.shader = Shader.Find ("Specular");
			bouton.material.SetColor ("_SpecColor", Color.green);
		}

		/*if(door.transform.position.x > 1.5){
			opening = false;
			door.transform.position.x = door.transform.position.x + 1;
		}*/
	}

	void OnTriggerEnter (Collider other){
		if (other.tag == "Ball") {
			opening = true;
		}

		Vector3 spawnPosition = new Vector3 (spawnValues.x, spawnValues.y, spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate (Door, spawnPosition, spawnRotation);
	}

	void OpenDoor (){
		door.transform.Translate (Vector3.right * Time.deltaTime * 5);
	}
}
