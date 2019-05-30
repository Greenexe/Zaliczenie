using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class karaczanAI : MonoBehaviour
{
    GameObject cel;
    Rigidbody2D rb;
    public float rotation = 3f,speed=10;
    Vector3 dir;
    Quaternion rottar;
    Quaternion zmiana;

    // Start is called before the first frame update
    void Start()
    {
        cel = GameObject.FindGameObjectWithTag("bohatyr");
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        dir = (cel.GetComponent<nowacame>().transform.position - transform.position).normalized;
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        rottar = Quaternion.AngleAxis(angle-90, Vector3.forward);
        

        transform.rotation = Quaternion.Slerp(transform.rotation, rottar, Time.deltaTime * rotation);
        rb.velocity = new Vector2(dir.x * speed, dir.y * speed);
       
        
    }
}
