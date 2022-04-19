using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
	private float timer = 0;
	//public float speed;
	
	public Text score;
	
	
    void Update()
    {
        timer += Time.deltaTime;
		score.text = "Score : " + timer.ToString ();
    }
}
