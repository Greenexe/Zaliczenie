﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drzwilewe : MonoBehaviour
{

    bool open = true;
    // Update is called once per frame
    void FixedUpdate()
    {
        GameObject drzwi = GameObject.FindWithTag("DOORS");

        if (drzwi.GetComponent<kartydodrzwi>().stateofdoor && open)
        {
            transform.position = new Vector3(transform.position.x - 170, transform.position.y, transform.position.z);
            open = false;
        }
        else if ((drzwi.GetComponent<kartydodrzwi>().stateofdoor == false) && (open == false))
        {


            transform.position = new Vector3(transform.position.x + 170, transform.position.y, transform.position.z);
            open = true;
        }


    }
}
