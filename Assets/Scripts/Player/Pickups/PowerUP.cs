using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PowerUP : MonoBehaviour
{
    public TextMeshProUGUI itemNotifier;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerCannons>().ActivatePowerUP();
            itemNotifier.SetText("Picked up PowerUP! Double cannon damage for 15s!");
            Destroy(gameObject);
        }
    }
}
