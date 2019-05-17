using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enablePoof : MonoBehaviour
{
    public GameObject poof;

    public GameObject moleMan;

    private Animation anim;

    private bool whacked;

    void Start()
    {
        anim = poof.GetComponent<Animation>();
    }

    // Start is called before the first frame updat

    // Update is called once per frame
    void Update()
    {
        if(whacked)
        {
            poof.SetActive(true);
            anim.Play("Poof"); //play animation once
            poof.SetActive(false); 
        }
    }
}
