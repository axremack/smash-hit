using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary {
	public float xMin, xMax, yMin, yMax;
}

public class MousePos : MonoBehaviour {

	public float x;
	public float y;
	private Transform tr;
	public Boundary boundary;
	//private Vector3 pos;

	void Start (){
		//tr = GetComponent<Transform> ();
	}

	void Update () {
		transform.position = new Vector3 (Mathf.Clamp (x + Input.mousePosition.x * Time.deltaTime, boundary.xMin, boundary.xMax), y + Mathf.Clamp (y + Input.mousePosition.y * Time.deltaTime, boundary.yMin, boundary.yMax), 0.0f) ;

		/*pos = tr.position;
		pos = pos + new Vector3 (Input.GetAxis ("Mouse X") * Time.deltaTime*5, Input.GetAxis ("Mouse Y") * Time.deltaTime*5,  0) ;
		tr.position = pos;*/
	}
}
