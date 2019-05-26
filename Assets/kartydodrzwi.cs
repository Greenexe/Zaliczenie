using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kartydodrzwi : MonoBehaviour
{
    string[] jakiekarty = new string[5];
    public string jakiklucz = "red";
    private int ilosccolliderow = 2;
    public bool stateofdoor=false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (ilosccolliderow < 0)
        {
            GameObject POSTAC = GameObject.Find("POSTAC");
            jakiekarty = POSTAC.GetComponent<karty>().karts;
            for (int i = 0; i < 5; i++)
            {
                if (jakiekarty[i]==jakiklucz)
                {
                    stateofdoor = true;

                }



                
            }
            

        }
        ilosccolliderow = ilosccolliderow - 1;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        stateofdoor = false;
    }

}
