using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZbierzTarcze : MonoBehaviour
{
    public int dodawanaTarcza = 20;
    public AudioClip sound;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Statystyki staty = collision.GetComponent<Statystyki>();

        if (staty != null)
        {
            if (!staty.ShieldIsFull())
            {
                staty.GiveShield(dodawanaTarcza);
                Destroy(gameObject);
                Audio.PlaySound(sound);
            }
        }
    }
}
