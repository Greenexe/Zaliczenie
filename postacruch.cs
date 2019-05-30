using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class postacruch : MonoBehaviour
{
    public float movment;
    private Rigidbody2D Rigi;
    private Vector3 pointofman;
    private Vector3 oldPointOfMan;
    public Vector2 calosci;

    public AudioClip sound;

    void Start()
    {
       Rigi = GetComponent<Rigidbody2D>();    
    }

    void FixedUpdate()
    {
        oldPointOfMan = pointofman;
        pointofman = new Vector3(transform.position.x, transform.position.y, transform.position.z);

        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if(oldPointOfMan.x != pointofman.x || oldPointOfMan.y != pointofman.y)
        {
            Audio.PlayLoopSound(sound);
        }
        else if(oldPointOfMan.x == pointofman.x && oldPointOfMan.y == pointofman.y)
        {
            Audio.StopLoopSound();
        }
        
        transform.position = new Vector3(pointofman.x + moveHorizontal * movment, pointofman.y + moveVertical * movment, pointofman.z);
        calosci = new Vector2(transform.position.x,transform.position.y);
    }
}