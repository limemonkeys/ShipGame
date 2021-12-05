using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RammerBowHitbox : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Damage if rammer and player collide
        if (other.gameObject.tag == "Player")
        {
            if (other.gameObject.name == "Starboard" || other.gameObject.name == "Port")
            {
                this.transform.parent.gameObject.GetComponent<EnemyShipStatus>().DamageEnemy(1);
                other.transform.parent.gameObject.GetComponent<ShipStatus>().DamagePlayer(3);
            }

            else if (other.gameObject.name == "Bow" || other.gameObject.name == "Stern")
            {
                this.transform.parent.gameObject.GetComponent<EnemyShipStatus>().DamageEnemy(1);
                other.transform.parent.gameObject.GetComponent<ShipStatus>().DamagePlayer(1);
            }
        }
    }
}
