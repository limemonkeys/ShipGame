using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAI : MonoBehaviour
{
    int finderDist = 100;
    int shootDist = 75;
    int health = 3;
    public Transform Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, Player.position) <= finderDist)
        {
            transform.LookAt(Player);
        }
        if (Vector3.Distance(transform.position, Player.position) <= shootDist)
        {
            // Shoot at player,
        }
        if (health <= 0)
        {

        }
    }
}