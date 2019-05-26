using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class staticcamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        GameObject bohatyr = GameObject.Find ( "POSTAC" ) ;
        Vector2 zmiany = bohatyr.GetComponent<postacruch>().calosci;
        transform.position =new Vector2( zmiany.x,zmiany.y);


    }
}
