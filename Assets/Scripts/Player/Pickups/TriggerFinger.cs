using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerFinger : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerCannons>().ActivateTriggerFinger();
            // Remove coin from game

            Destroy(gameObject);
        }
    }
}
