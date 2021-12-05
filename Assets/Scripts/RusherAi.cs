using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RusherAi : MonoBehaviour
{

    int finderDist = 50;
    int MoveSpeed = 3;
    int health = 1;
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
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;
        }
        //Collision, h
        if (health <= 0)
        {

        }
    }
    void Die()
    {

    }
}