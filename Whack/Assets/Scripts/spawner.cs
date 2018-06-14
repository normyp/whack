using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class spawner : MonoBehaviour {

    public int spawnMax = 9;

    public int timerEnd;

    public List<GameObject> moles = new List<GameObject>();

    public float timer = 0.0f;

    public int selectedMole;

    public bool gameOver = false;

    public int score;

    bool spawned = false;

    void Start()
    {
        for(int i = 0; i <= 8; i++)
        {
            //Adds all the spawns to the list
            moles.Add(GameObject.FindGameObjectWithTag("mole"));
            moles[i].SetActive(false);
        }
    }

	// Update is called once per frame
	void Update () {

            if (!spawned) //Whilst nothing has been spawned
            {
            	//Spawn moles
                selectedMole = Random.Range(0, 9);
				//Debug.Log("Selected mole is " + selectedMole); 
                moles[selectedMole].SetActive(true);
                spawned = true;
            }
	        else if (timer >= 2.0f)
	        {
	        	moles[selectedMole].SetActive(false);
	        	if (timer >= 3.5f)
	       		{
	        		timer = 0.0f;
	        		spawned = false;
	        	}
	        }

	        timer += Time.deltaTime;
	        //Debug.Log("Timer is at: " +  timer);
    }
}
