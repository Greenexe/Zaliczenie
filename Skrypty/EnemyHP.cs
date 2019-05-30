/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{

    public float Ehp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         GameObject Ene = GameObject.FindGameObjectWithTag("Shot");
        TakeDamage(Ene.GetComponent<shot>().damage);
        if (Ehp<=0)
        {
            Destroy(this);
        }



    }
   public void TakeDamage(float damage)
    {
        Ehp=-damage;




    }
}
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{

    
    public int health;
    public GameObject deathEffect;
    public GameObject explosion;

    private void Update()
    {
        if (health <= 0)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
      
        Instantiate(explosion, transform.position, Quaternion.identity);
        health -= damage;
    }
}