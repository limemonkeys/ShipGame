using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortHitbox : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Damage if player and enemy collide
        if (other.gameObject.tag == "Enemy")
        {
            if (other.gameObject.name == "Starboard" || other.gameObject.name == "Port")
            {
                other.transform.parent.gameObject.GetComponent<EnemyShipStatus>().DamageEnemy(1);
                this.transform.parent.gameObject.GetComponent<ShipStatus>().DamagePlayer(1);
            }
        }
        // Damage only to player if hitting terrain
        else if (other.gameObject.tag != "Water")
        {
            this.transform.parent.gameObject.GetComponent<ShipStatus>().DamagePlayer(1);
        }
    }
}
