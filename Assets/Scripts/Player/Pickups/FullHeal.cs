using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullHeal : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<ShipStatus>().FullHealPlayer();
            // Remove coin from game

            Destroy(gameObject);
        }
    }
}
