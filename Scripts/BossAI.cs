using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI : MonoBehaviour
{

    int finderDist = 50;
    int currSpeed = 0;
    int health = 5;
    public Transform Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position += transform.forward * 8 * Time.deltaTime;

        /*
        if (Vector3.Distance(transform.position, Player.position) <= finderDist)
        {
            transform.LookAt(Player);
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        }
        */
        if (health <= 0)
        {

        }
    }
}