using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipStatus : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public void DamageEnemy(int damageAmount)
    {
        currentHealth = currentHealth - 1;
        if (currentHealth <= 0) 
        {
            Destroy(gameObject);
        }
    }
}
