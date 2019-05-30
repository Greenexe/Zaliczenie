using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZbierzApteczke : MonoBehaviour
{
    public int dodawaneHP = 20;
    public AudioClip sound;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Statystyki staty = collision.GetComponent<Statystyki>();

        if(staty != null)
        {
            if (!staty.HealthIsFull())
            {
                staty.GiveHealth(dodawaneHP);
                Destroy(gameObject);
                Audio.PlaySound(sound);
            }
        } 
    }
}
