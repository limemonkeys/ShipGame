using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trident : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerCannons>().ActivateTrident();
            // Remove coin from game

            Destroy(gameObject);
        }
    }
}
