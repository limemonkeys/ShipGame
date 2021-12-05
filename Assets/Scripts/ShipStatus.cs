using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShipStatus : MonoBehaviour
{
    public TextMeshProUGUI HealthText;
    public int maxHealth;
    public int currentHealth;

    public void DamagePlayer(int damageAmount) 
    {
        currentHealth = currentHealth - 1;
        if (currentHealth < 0) {
            currentHealth = 0;
        }
        HealthText.SetText("Health " + currentHealth);
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
