using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nowycelownik : MonoBehaviour
{

    public float offset;

    public GameObject projectile;
    public Camera cam;
    postacruch ruch;
   public Vector2 miejscecelownika;


    private void Start()
    {

        ruch = GetComponent<postacruch>();


    }

    private void Update()
    {
        
    Vector2 mousePosition = new Vector2(cam.ScreenToWorldPoint(Input.mousePosition).x, cam.ScreenToWorldPoint(Input.mousePosition).y);

        GameObject miejsce = GameObject.FindWithTag("bohatyr");
        Transform point = miejsce.GetComponent<nowacame>().shotPoint;

        Vector2 firePP = new Vector2(point.transform.position.x, point.transform.position.y);
        float odleglosc = Mathf.Sqrt((mousePosition.x+ point.transform.position.x) *(mousePosition.x + point.transform.position.x) + (mousePosition.y + point.transform.position.y) * (mousePosition.y + point.transform.position.y));
        RaycastHit2D hit = Physics2D.Raycast(firePP, mousePosition,odleglosc);
        if(hit.collider!=null)
        {
            miejscecelownika = hit.point;
           

        }
        else
        {
            miejscecelownika =new Vector2(mousePosition.x,mousePosition.y);
           
        }
        




    }
}


