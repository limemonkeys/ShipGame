using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaFuel : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<ShipMovement>().ActivateMegaFuel();

            Destroy(gameObject);
        }
    }
}
