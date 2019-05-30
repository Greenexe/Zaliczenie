
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseshot : MonoBehaviour
{

    private Vector3 mousePosition;
    private Rigidbody2D rb;
    private Vector2 direction;
    public float moveSpeed = 400f;
    public Vector2 celownik, miejscepostaci;
    cameradirection Zzz;
    public int ammo=1;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        kat();
        strzal();
       
        


    }

    void strzal()
    {

        if (Input.GetMouseButton(0))
        {
            if (ammo != 0)
            {
                kat();
                GameObject POSTAC = GameObject.Find("POSTAC");
                celownik = POSTAC.GetComponent<nowycelownik>().miejscecelownika;
                miejscepostaci = POSTAC.GetComponent<postacruch>().calosci;
                mousePosition = celownik;
                direction = (celownik - miejscepostaci).normalized;
                rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
                transform.rotation = Zzz.transform.rotation;
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
        }



    }


    void kat()
    {
        
        Zzz = GetComponent<cameradirection>();


    }
}