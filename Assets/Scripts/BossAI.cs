using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI : MonoBehaviour
{

    public int finderDist = 150;
    public int ShooterDist = 40;
    bool foundplayer = false;
    int lastTurn = 0;
    public Transform Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        

        
        if (Vector3.Distance(transform.position, Player.position) >= finderDist)
        {
            foundplayer = false;
            transform.position += transform.forward * 4 * Time.deltaTime;
        }
        if (Vector3.Distance(transform.position, Player.position) >= ShooterDist && Vector3.Distance(transform.position, Player.position) <= finderDist) // finding distance
        {
            if (!foundplayer)
            {
                transform.LookAt(Player);
                transform.position += transform.forward * 8 * Time.deltaTime;
            }
            else
            {
                if (lastTurn == 1)
                {
                    rightTurn();
                }
                else if (lastTurn == 2)
                {
                    leftTurn();
                }
            }
        }
        else if (Mathf.Abs(Player.transform.position.x - transform.position.x) <= ShooterDist) //Shooter Distance
        {
            foundplayer = true;
            if (Player.transform.position.x < transform.position.x && Mathf.Abs(Player.transform.position.x - transform.position.x) > 4)
            {
                leftTurn();
                lastTurn = 1;
            }
            else if (Player.transform.position.x > transform.position.x && Mathf.Abs(Player.transform.position.x - transform.position.x) > 4)
            {
                rightTurn();
                lastTurn = 2;
            }
        }
        
           
        
    }
    void leftTurn()
    {
        transform.position += transform.forward * 0 * Time.deltaTime;
        transform.Rotate(0f, -0.3f, 0f, Space.Self);
        transform.position += transform.forward * 8 * Time.deltaTime;
    }
    void rightTurn()
    {
        transform.position += transform.forward * 0 * Time.deltaTime;
        transform.Rotate(0f, 0.3f, 0f, Space.Self);
        transform.position += transform.forward * 8 * Time.deltaTime;
    }
    void die()
    {

    }
    void fire()
    {

    }
}