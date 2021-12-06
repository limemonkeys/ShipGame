//https://www.youtube.com/watch?v=BLfNP4Sc_iA
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShipStatus : MonoBehaviour
{
    public TextMeshProUGUI HealthText;
    public int maxHealth = 10;
    public int currentHealth;

    public ParticleSystem playerSmoke;
    public ParticleSystem playerFire;

    public bool powerUP = false;
    public bool triggerFinger = false;
    public bool trident = false;
    public bool megaFuel = false;

    public Slider slider;

    public AudioSource selfDamage;

    void Start() 
    {
        if (PlayerSelectController.player == "tank")
        {
            maxHealth = 11;
        }
        currentHealth = maxHealth;
        slider.maxValue = currentHealth;
    }

    public void UpdateHealth() 
    {
        slider.value = currentHealth;
    }


    public void DamagePlayer(int damageAmount) 
    {
        selfDamage.Play();
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
        UpdateHealth();
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void HealPlayer(int healAmount)
    {
        currentHealth = currentHealth + healAmount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
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
        HealthText.SetText("Health: " + currentHealth);
        UpdateHealth();
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void FullHealPlayer()
    {
        currentHealth = maxHealth;
        playerSmoke.Stop();
        playerFire.Stop();
        HealthText.SetText("Health " + currentHealth);
        UpdateHealth();
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
