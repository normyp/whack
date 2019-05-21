using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enablePoof : MonoBehaviour
{
    public GameObject poof;

    public GameObject mole;

    public bool whacked;

    private Animation anim;

    void Start()
    {
        poof = GameObject.FindGameObjectWithTag("poof");
        mole = GameObject.FindGameObjectWithTag("mole");
        anim = poof.GetComponent<Animation>();
        whacked = mole.GetComponent<hit>().whacked;
    }

    // Start is called before the first frame updat

    // Update is called once per frame
    void Update()
    {
        if(whacked)
        {
            Debug.Log("hit");
            poof.SetActive(true);
            anim.Play("Poof"); //play animation once
            poof.SetActive(false); 
        }
    }
}
