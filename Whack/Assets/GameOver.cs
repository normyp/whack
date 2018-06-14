using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

	GameObject gameMan;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject gameMan = GameObject.FindWithTag("gameMan");
		lives player = gameMan.GetComponent<lives>();
       	int life = player._lives;
	}
}
