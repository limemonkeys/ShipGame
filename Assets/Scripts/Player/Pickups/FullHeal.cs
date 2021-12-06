using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class FullHeal : MonoBehaviour
{
    public TextMeshProUGUI itemNotifier;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<ShipStatus>().FullHealPlayer();
            itemNotifier.SetText("Picked up Full Health! Fully healed!");
            Destroy(gameObject);
        }
    }
}
