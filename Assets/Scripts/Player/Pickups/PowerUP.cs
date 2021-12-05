using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerCannons>().ActivatePowerUP();
            // Remove coin from game

            Destroy(gameObject);
        }
    }
}
