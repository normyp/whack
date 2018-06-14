using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class spawner : MonoBehaviour {

    public List<GameObject> moles = new List<GameObject>();

	public GameObject gameMan;

    public GameObject whack;

    public float timer = 0.0f;

    public int selectedMole;

    public int score;

    bool spawned = false;

    bool onetime = false;

    void Start()
    {
        for(int i = 0; i <= 8; i++)
        {
            //Adds all the spawns to the list
            moles.Add(GameObject.FindGameObjectWithTag("mole"));
            moles[i].SetActive(false);
        }
    }


    void LoseLife()
    {
        GameObject gameMan = GameObject.FindWithTag("gameMan"); //Creates an instance of game manager so that the component lives can be used
        lives player = gameMan.GetComponent<lives>(); //Creates an instance of the lives script so that lives can be accessed
        player._lives--; 
        onetime = true;
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
                onetime = false;
            }
	        else if (timer >= 2.0f)
	        {
                moles[selectedMole].SetActive(false);
                //You missed the mole.
                //Now lose a life.
                if(!onetime)
                {
                    LoseLife();
                }
	        	//Decrement lives
	        	else if (timer >= 3.5f)
	       		{
	        		timer = 0.0f;
	        		spawned = false;
	        	}
	        }
	        timer += Time.deltaTime;
	        //Debug.Log("Timer is at: " +  timer);
    }

}
