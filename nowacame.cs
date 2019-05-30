/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nowacame : MonoBehaviour
{

    public float offset;

    public GameObject strzal;
    
    public Transform shotPoint;
   

    private float timeBtwShots;
    public float startTimeBtwShots;

    private void Update()
    {
        // Handles the weapon rotation
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButton(0))
            {
              
                
                Instantiate(strzal, shotPoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }


    }
}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nowacame : MonoBehaviour
{

    public float offset;

    public GameObject projectile;
    public GameObject shotEffect;
    public Transform shotPoint;
   

    private float timeBtwShots;
    public float startTimeBtwShots;
    public AudioClip shot;
    private void Update()
    {
        // Handles the weapon rotation
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotZ + offset);

        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                Audio.PlaySound(shot);
                Instantiate(shotEffect, shotPoint.position, Quaternion.identity);
                
                Instantiate(projectile, shotPoint.position, transform.rotation);
                timeBtwShots = startTimeBtwShots;
            }
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }


    }
}