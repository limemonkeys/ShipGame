using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Heal : MonoBehaviour
{
    public TextMeshProUGUI itemNotifier;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<ShipStatus>().HealPlayer(3);
            itemNotifier.SetText("Picked up Heal! Healed three hits!");
            Destroy(gameObject);
        }
    }
}
