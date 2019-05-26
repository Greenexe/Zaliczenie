using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class postacruch : MonoBehaviour
{
    public float movment;
    private Rigidbody2D Rigi;
    private Vector3 pointofman;
    public Vector2 calosci;
    
    // Start is called before the first frame update
    void Start()
    {
       Rigi = GetComponent<Rigidbody2D>();    
    }

    void FixedUpdate()
    {
        pointofman = new Vector3(transform.position.x, transform.position.y, transform.position.z);

      
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
        
        transform.position = new Vector3(pointofman.x + moveHorizontal * movment, pointofman.y + moveVertical * movment, pointofman.z);
        calosci =new Vector2(transform.position.x,transform.position.y);
    }
    
    void Update()
    {
       
    }
   


}
