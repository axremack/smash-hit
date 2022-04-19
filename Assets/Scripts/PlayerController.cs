using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*[System.Serializable]
public class Boundary {
	public float xMin, xMax, yMin, yMax;
}*/

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;
	//public Boundary boundary;

	private Vector3 mousePosition;
	
	public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
	Ray rayMouse;

    private float nextFire;

	public float comptBall;
	public Text ball;
	
	private GameController gameController;

	void Start ()
	{
		rb = GetComponent<Rigidbody> ();
		comptBall = 20;
		
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



	void Update ()
    {
        if(comptBall > 0){
			if (Input.GetButton("Fire1") && Time.time > nextFire)
			{
				nextFire = Time.time + fireRate;
				Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
				comptBall--;
			}

			ball.text = "Balles restantes : " + comptBall.ToString ();
		}
		else if (comptBall <= 0){
			gameController.GameOver();

		}
    }
}
