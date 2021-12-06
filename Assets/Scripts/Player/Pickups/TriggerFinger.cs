using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TriggerFinger : MonoBehaviour
{
    public TextMeshProUGUI itemNotifier;

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerCannons>().ActivateTriggerFinger();
            itemNotifier.SetText("Picked up Trigger Finger! Reload time halved for 15s!");
            Destroy(gameObject);
        }
    }
}
