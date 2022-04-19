using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverObjects : MonoBehaviour {
	public float speed;
	private Rigidbody rb;
	
	private GameController gameController;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		rb.velocity = new Vector3(0,0,1) * (- speed - (Time.time / 20));
		
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
	
	void Update (){
		if (gameController.gameOver) {
			rb.velocity = new Vector3 (0, 0, 0);
		} 
		/*else {
			if (transform.position.x < -2) {
				transform.position.x += 0.5;
			}
			else if (transform.position.x > 2) {
				transform.position.x -= 0.5;
			}
		}*/
	}

}
