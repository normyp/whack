using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enablePoof : MonoBehaviour
{
    public GameObject poof;

    public GameObject mole;

    public bool whacked;

    private Animation anim;

    public bool poofAnim;

    void Start()
    {
        anim = poof.GetComponent<Animation>();
        whacked = mole.GetComponent<hit>().whacked;
        Debug.Log(whacked);
        poof.SetActive(false);
    }

    // Start is called before the first frame updat

    // Update is called once per frame
    void Update()
    {
        if(whacked)
        {
            Debug.Log("hit");
            Debug.Log(whacked);
            poof.SetActive(true);
            anim.Play("Poof"); //play animation once
        }
    }
}
