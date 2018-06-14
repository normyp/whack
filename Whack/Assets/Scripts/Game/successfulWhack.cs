using UnityEngine;
using System.Collections;

public class successfulWhack : MonoBehaviour {

    public GameObject moleMan;

    void OnMouseDown()
    {
        GameObject moleMan = GameObject.FindWithTag("man"); //Creates an instance of mole manager so that the component spawner can be used
        spawner spawn = moleMan.GetComponent<spawner>(); //Creates an instance of the spawner script so that score can be accessed

        //missed = false;

        gameObject.SetActive(false);
        spawn.score++; 
       
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
