using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enablePoof : MonoBehaviour
{
    public bool hit = false;
    // Start is called before the first frame update
    void Awake()
    {
        // gameObject.SetActive(false);
    }

    void OnMouseDown()
    {
        hit = true;
        if(hit = true)
        {
            //Play animation once then setactive to false
        }
        //gameObject.Color.a = 0.0f;
    }

    void OnMouseUp()
    {
        hit = false;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.SetActive(true);
        /* if hit occurs
         *setactive to true
         * play animation
         * then set active to false
         */
    }
}
