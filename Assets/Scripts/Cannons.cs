//https://www.youtube.com/watch?v=THnivyG0Mvo
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;

public class Cannons : MonoBehaviour
{
    public int damage = 0;
    public float range = 60f;
    public float fps = 2f;

    public Camera PortCannon;
    public Camera StarboardCannon;

    public ParticleSystem flashPort;
    public ParticleSystem flashStarboard;

    public float reloading = 0f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time >= reloading) 
        {
            reloading = Time.time + fps;
            flashPort.Play();
            flashStarboard.Play();
            Shoot();
        }
    }

    void Shoot() 
    {
        RaycastHit hitPortside;
        RaycastHit hitStarboardside;

        if (Physics.Raycast(PortCannon.transform.position, PortCannon.transform.forward, out hitPortside, range)) 
        {
            if (hitPortside.transform.gameObject.tag == "Enemy") 
            {
                hitPortside.transform.gameObject.GetComponent<EnemyShipStatus>().DamageEnemy(1);
                
            }
        }

        if (Physics.Raycast(StarboardCannon.transform.position, StarboardCannon.transform.forward, out hitStarboardside, range))
        {
            if (hitStarboardside.transform.gameObject.tag == "Enemy")
            {
                hitStarboardside.transform.gameObject.GetComponent<EnemyShipStatus>().DamageEnemy(1);

            }
        }
    }
}
