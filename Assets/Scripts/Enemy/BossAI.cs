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

    public Camera PortCannon;
    public Camera StarboardCannon;
    public ParticleSystem flashPort;
    public ParticleSystem flashStarboard;
    public float range = 60f;
    public float fps = 4f;
    public float reloadingPort = 0f;
    public float reloadingStarboard = 0f;

    public int starboardCounter = 0; //to make the AI not too strong
    public int portsideCounter = 0; //to make the AI not too strong

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
            leftTurn();
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

        RaycastHit hitPortside;
        if (Physics.Raycast(PortCannon.transform.position, PortCannon.transform.forward, out hitPortside, range) && Time.time >= reloadingPort)
        {
            if (hitPortside.transform.gameObject.tag == "Player")
            {
                if (portsideCounter < 3)
                {
                    portsideCounter += 1;
                }
                else
                {
                    flashPort.Play();
                    ShootPortside(hitPortside);
                    portsideCounter = 0;
                }
                reloadingPort = Time.time + fps;
            }
        }


        RaycastHit hitStarboardside;
         if (Physics.Raycast(StarboardCannon.transform.position, StarboardCannon.transform.forward, out hitStarboardside, range) && Time.time >= reloadingStarboard)
         {
            if (hitPortside.transform.gameObject.tag == "Player")
            {
                if (starboardCounter < 3)
                {
                    starboardCounter += 1;
                }
                else
                {
                    flashStarboard.Play();
                    ShootStarboardside(hitPortside);
                    starboardCounter = 0;
                }
                reloadingStarboard = Time.time + fps;
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
    void ShootPortside(RaycastHit hitPortside)
    {
        
        if (Physics.Raycast(PortCannon.transform.position, PortCannon.transform.forward, out hitPortside, range))
        {
            if (hitPortside.transform.gameObject.tag == "Player")
            {
                hitPortside.transform.gameObject.GetComponent<ShipStatus>().DamagePlayer(1);

            }
        }
    }

    void ShootStarboardside(RaycastHit hitStarboardside)
    {

        if (Physics.Raycast(StarboardCannon.transform.position, StarboardCannon.transform.forward, out hitStarboardside, range))
        {
            if (hitStarboardside.transform.gameObject.tag == "Player")
            {
                hitStarboardside.transform.gameObject.GetComponent<ShipStatus>().DamagePlayer(1);

            }
        }
    }
}