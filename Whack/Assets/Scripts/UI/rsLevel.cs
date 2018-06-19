using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rsLevel : MonoBehaviour {

	public float timer = 0.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(timer >= 3.0f)
		{
			Application.LoadLevel("Whack!");
		}
		timer += Time.deltaTime;
	}
}
