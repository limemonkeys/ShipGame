using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MegaFuel : MonoBehaviour
{
    public TextMeshProUGUI itemNotifier;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<ShipMovement>().ActivateMegaFuel();
            itemNotifier.SetText("Picked up Mega Fuel! Increased acceleration for 15s!");
            Destroy(gameObject);
        }
    }
}
