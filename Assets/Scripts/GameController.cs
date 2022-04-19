using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public GameObject hazard;
	public GameObject bonus;
	public GameObject door;
	public Vector3 spawnValues;

	public int hazardCount;
	public float spawnWait1;
	public float spawnWait2;
	public float startWait;
	public float waveWait;
	
	public Text restartText;
	public Text gameOverText;
	private bool restart;
	public bool gameOver;

	private float largeur;

	void Start ()
	{
		restart = false;
		gameOver = false;
		restartText.text = "";
		gameOverText.text = "";
		StartCoroutine (SpawnWaves ());
	}

	IEnumerator SpawnWaves ()
	{
		yield return new WaitForSeconds (startWait);
		while (true)
		{
			for (int i = 0; i < hazardCount; i++)
			{
				Vector3 spawnPosition1 = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				//Vector3 spawnPosition2 = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), bonus.transform.position.y , spawnValues.z);
				//Vector3 spawnPosition3 = new Vector3 (door.transform.position.x, door.transform.position.y , door.transform.position.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition1, spawnRotation);
				largeur = Random.Range (1,5);
				transform.localScale += new Vector3(largeur, 0, 0);
				//Instantiate (bonus, spawnPosition2, spawnRotation);
				yield return new WaitForSeconds (spawnWait1);
			}
			for (int i = 0; i < hazardCount; i++)
			{
				//Vector3 spawnPosition1 = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
				Vector3 spawnPosition2 = new Vector3 (Random.Range (-spawnValues.x, spawnValues.x), bonus.transform.position.y , spawnValues.z);
				//Vector3 spawnPosition3 = new Vector3 (door.transform.position.x, door.transform.position.y , door.transform.position.z);
				Quaternion spawnRotation = Quaternion.identity;
				//Instantiate (hazard, spawnPosition1, spawnRotation);
				Instantiate (bonus, spawnPosition2, spawnRotation);
				yield return new WaitForSeconds (spawnWait2);
			}
			yield return new WaitForSeconds (waveWait);
			
			if (gameOver){
				restartText.text = "Appuyez sur R pour redemarrer";
				restart = true;
				break;
			}
		}
	}
	
	void Update (){
		if (restart)
        {
            if (Input.GetKeyDown (KeyCode.R))
            {
                Application.LoadLevel (Application.loadedLevel);
            }
        }
	}
	
	public void GameOver (){
		gameOverText.text = "Game Over";
		gameOver = true;
	}
}
