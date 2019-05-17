using UnityEngine;
using System.Collections;

public class hit : MonoBehaviour {

    public GameObject moleMan;
    public bool whacked;

    public GameObject poof;

    void OnMouseDown()
    {
        GameObject moleMan = GameObject.FindWithTag("man"); //Creates an instance of mole manager so that the component spawner can be used
        spawner spawn = moleMan.GetComponent<spawner>(); //Creates an instance of the spawner script so that score can be accessed

        //missed = false;

        gameObject.SetActive(false);
        spawn.score++; 
        whacked = true;
        poof.whacked = true;

        //Need to override default spawn system and just make a new mole
       
        //Debug.Log("Hit");   
    }

    /*public bool Missed()
    {
    	if(missed)
    	{
    		check = true;
    	}
    	else
    	{
    		check = false;
    	}
    	return check;
    }*/
}
