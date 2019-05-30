using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dym : MonoBehaviour
{

    float timenow;
   float ruch=0;
    // Start is called before the first frame update
    void Start()
    {
        timenow = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(ruch+timenow<=Time.time)
        {
            if(ruch<6)
            {
                transform.localScale = new Vector3(transform.localScale.x + 1, transform.localScale.y + 1, transform.localScale.z);
            }
            if ((ruch > 6)&&(ruch<12))
            {
                transform.localScale = new Vector3(transform.localScale.x -1, transform.localScale.y - 1, transform.localScale.z);
            }
            if (ruch==12)
            {

                transform.localScale = new Vector3(0, 0, 0);
            }

            ruch++;
        }

        
    }
}
