using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShipStatus : MonoBehaviour
{
    public TextMeshProUGUI HealthText;
    public int maxHealth;
    public int currentHealth;

    public ParticleSystem playerSmoke;
    public ParticleSystem playerFire;

    public void DamagePlayer(int damageAmount) 
    {
        currentHealth = currentHealth - 1;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
        else if (currentHealth <= maxHealth / 4)
        {
            playerSmoke.Stop();
            playerFire.Play();
        }
        else if (currentHealth <= maxHealth / 2)
        {
            playerSmoke.Play();
            playerFire.Stop();
        }
        else
        {
            playerSmoke.Stop();
            playerFire.Stop();
        }
        HealthText.SetText("Health " + currentHealth);
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
