using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smoke : MonoBehaviour
{
    private float time;
    public float lifespan;
    // Start is called before the first frame update
    void Start()
    {
        time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(time+lifespan<Time.time)
        {
            transform.position = new Vector3(transform.position.x,transform.position.y,0);


        }
        else
        {

            Destroy(gameObject);



        }


    }
}
