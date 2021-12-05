﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.GetComponent<ShipStatus>().HealPlayer(3);
            // Remove coin from game

            Destroy(gameObject);
        }
    }
}
