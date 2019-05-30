using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statystyki : MonoBehaviour
{
    public int maxHealth = 100;
    public int maxShield = 100;

    int currentHealth;
    int currentShield;

    void Start()
    {
        //currentHealth = maxHealth;
        // currentShield = maxShield;

        currentHealth = 20;
        currentShield = 20;

        HPBar.ChangeBar(currentHealth, maxHealth);
        ShieldBar.ChangeBar(currentShield, maxShield);
        //DealDamage(80);
    }

    /* - - - - - Ogólne - - - - - */

    public void DealDamage(int amount)
    {
        if (currentShield > 0)
        {
            currentShield -= amount;
            if (currentShield < 0)
                currentShield = 0;
        }
        else
        {
            currentHealth -= amount;
            if (currentHealth < 0)
                currentHealth = 0;
        }
        HPBar.ChangeBar(currentHealth, maxHealth);
    }

    /* - - - - - Zdrowie - metody - - - - - */

    public bool HealthIsFull()
    {
        if (currentHealth == maxHealth) return true;
        else return false;
    }

    public void GiveHealth(int amount)
    {
        if (currentHealth > 0 && currentHealth < maxHealth)
        {
            currentHealth += amount;
            if (currentHealth > 100) currentHealth = 100; 
        }

        Debug.Log(currentHealth + "/" + maxHealth);
        HPBar.ChangeBar(currentHealth, maxHealth);
    }

    public int GetHealth()
    {
        return currentHealth;
    }

    /* - - - - - Tarcza - metody - - - - - */

    public bool ShieldIsFull()
    {
        if (currentShield == maxShield) return true;
        else return false;
    }

    public void GiveShield(int amount)
    {
        if (currentShield < maxShield)
        {
            currentShield += amount;
            if (currentShield > 100) currentShield = 100;
            if (currentShield < 0) currentShield = 0;
        }

        Debug.Log(currentShield + "/" + maxShield);
        ShieldBar.ChangeBar(currentShield, maxShield);
    }

    public int GetShield()
    {
        return currentShield;
    }
}
