//https://www.youtube.com/watch?v=THnivyG0Mvo
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class PlayerCannons : MonoBehaviour
{
    public int damage = 0;
    public float range = 60f;
    public float fps = 2f;

    public Camera PortCannon;
    public Camera StarboardCannon;

    public ParticleSystem flashPort;
    public ParticleSystem flashStarboard;

    public float reloadingPort = 0f;
    public float reloadingStarboard = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time >= reloadingPort) 
        {
            reloadingPort = Time.time + fps;
            flashPort.Play();
            ShootPortside();
        }
        if (Input.GetKey(KeyCode.Mouse1) && Time.time >= reloadingStarboard)
        {
            reloadingStarboard = Time.time + fps;
            flashStarboard.Play();
            ShootStarboardSide();
        }
    }

    void ShootPortside()
    {
        RaycastHit hitPortside;

        if (Physics.Raycast(PortCannon.transform.position, PortCannon.transform.forward, out hitPortside, range))
        {
            if (hitPortside.transform.gameObject.tag == "Enemy")
            {
                hitPortside.transform.gameObject.GetComponent<EnemyShipStatus>().DamageEnemy(1);

            }
        }
    }

    void ShootStarboardSide() 
    {
        RaycastHit hitStarboardside;

        if (Physics.Raycast(StarboardCannon.transform.position, StarboardCannon.transform.forward, out hitStarboardside, range))
        {
            if (hitStarboardside.transform.gameObject.tag == "Enemy")
            {
                hitStarboardside.transform.gameObject.GetComponent<EnemyShipStatus>().DamageEnemy(1);

            }
        }
    }
}
