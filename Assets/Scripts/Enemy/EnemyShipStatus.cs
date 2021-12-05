using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipStatus : MonoBehaviour
{
    public int maxHealth;
    public int currentHealth;

    public ParticleSystem enemySmoke;
    public ParticleSystem enemyFire;

    public void DamageEnemy(int damageAmount)
    {
        currentHealth = currentHealth - 1;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
        else if (currentHealth <= maxHealth / 4)
        {
            enemySmoke.Stop();
            enemyFire.Play();
        }
        else if (currentHealth <= maxHealth / 2)
        {
            enemySmoke.Play();
            enemyFire.Stop();
        }
        else 
        {
            enemySmoke.Stop();
            enemyFire.Stop();
        }
        if (currentHealth <= 0) 
        {
            Destroy(gameObject);
        }
    }
}
