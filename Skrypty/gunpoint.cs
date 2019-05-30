using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunpoint : MonoBehaviour
{
    
   public Vector2 celownik;
    
   
    
    // Start is called before the first frame update
    void Start()
    {
       

        GameObject POSTAC = GameObject.Find("POSTAC");

        if (POSTAC != null)
        {
            celownik = POSTAC.GetComponent<nowycelownik>().miejscecelownika;
        }


       
        
    }


    private void Update()
    {
        GameObject POSTAC = GameObject.Find("POSTAC");
        celownik = POSTAC.GetComponent<nowycelownik>().miejscecelownika;
        transform.position = celownik;


    }
}
    /*
    void Update()
    {
        Vector2 poczatek = new Vector2(ruch.all.x, ruch.all.y);
        Vector2 koniec = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
         hit = Physics2D.Raycast(poczatek, koniec);

        Ray position = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics2D.Raycast(position, out hit, Range))
        {
           
        }

        if (hit.collider != null)
        {



        }

    }
}*/