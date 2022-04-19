using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMover : MonoBehaviour {
	public float speed;
	public GameObject door;
	private GameController gameController;

	void Start (){

		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
        if (gameControllerObject != null)
        {
            gameController = gameControllerObject.GetComponent <GameController>();
        }
        if (gameController == null)
        {
            Debug.Log ("Cannot find 'GameController' script");
        }
	}
	
	void Update(){
		if(gameController.gameOver){
			door.transform.Translate(0,0,0);
		}
		else {
			door.transform.Translate(Vector3.forward * Time.deltaTime * (- speed - (Time.time / 20)));
			if (door.transform.position.z < 6) {
				Destroy(gameObject);
			}
		}
	}
}
