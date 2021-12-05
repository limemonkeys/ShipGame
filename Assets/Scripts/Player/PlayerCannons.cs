//https://www.youtube.com/watch?v=THnivyG0Mvo
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCannons : MonoBehaviour
{
    public int damage = 1;
    public float range = 60f;
    public float fps = 2f;

    public Camera PortCannon;
    public Camera StarboardCannon;

    public Camera PortCannonTriRight;
    public Camera PortCannonTriLeft;
    public Camera StarboardCannonTriRight;
    public Camera StarboardCannonTriLeft;

    public ParticleSystem flashPort;
    public ParticleSystem flashStarboard;

    public ParticleSystem flashPortTriRight;
    public ParticleSystem flashPortTriLeft;
    public ParticleSystem flashStarboardTriRight;
    public ParticleSystem flashStarboardTriLeft;

    public float reloadingPort = 0f;
    public float reloadingStarboard = 0f;

    public float reloadingPortTriRight = 0f;
    public float reloadingPortTriLeft = 0f;
    public float reloadingStarboardTriRight = 0f;
    public float reloadingStarboardTriLeft = 0f;

    public bool tridentActive = false;
    public float tridentDuration = 0f;

    public bool powerUPActive = false;
    public float powerUPDuration = 0f;

    public bool triggerFingerActive = false;
    public float triggerFingerDuration = 0f;

    public Slider portCannonSlider;
    public Slider starboardCannonSlider;

 

    // Update is called once per frame
    void Update()
    {
        portCannonSlider.value = Time.time;
        starboardCannonSlider.value = Time.time;
        if (tridentActive) 
        {
            tridentDuration -= Time.deltaTime;
            if (tridentDuration < 0f) 
            {
                tridentActive = false;
                tridentDuration = 0f;

            }
        }

        if (powerUPActive)
        {
            powerUPDuration -= Time.deltaTime;
            if (powerUPDuration < 0f)
            {
                powerUPActive = false;
                damage = 1;
                powerUPDuration = 0f;

            }
        }

        if (triggerFingerActive)
        {
            triggerFingerDuration -= Time.deltaTime;
            if (triggerFingerDuration < 0f)
            {
                triggerFingerActive = false;
                fps = 2f;
                triggerFingerDuration = 0f;

            }
        }

        if (Input.GetKey(KeyCode.Mouse0) && Time.time >= reloadingPort) 
        {
            portCannonSlider.minValue = Time.time;
            reloadingPort = Time.time + fps;
            portCannonSlider.maxValue = reloadingPort;
            flashPort.Play();
            ShootPortside();
            if (tridentActive) 
            {
                reloadingPortTriRight = Time.time + fps;
                reloadingPortTriLeft = Time.time + fps;
                flashPortTriRight.Play();
                flashPortTriLeft.Play();
                ShootPortsideRight();
                ShootPortsideLeft();
            }
        }
        if (Input.GetKey(KeyCode.Mouse1) && Time.time >= reloadingStarboard)
        {
            starboardCannonSlider.minValue = Time.time;
            reloadingStarboard = Time.time + fps;
            starboardCannonSlider.maxValue = reloadingStarboard;
            flashStarboard.Play();
            ShootStarboardSide();
            if (tridentActive)
            {
                reloadingStarboardTriRight = Time.time + fps;
                reloadingStarboardTriLeft = Time.time + fps;
                flashStarboardTriRight.Play();
                flashStarboardTriLeft.Play();
                ShootStarboardSideRight();
                ShootStarboardSideLeft();
            }
        }
    }

    public void ActivateTrident() 
    {
        tridentActive = true;
        tridentDuration = Time.time + 15f;
    }

    public void ActivatePowerUP()
    {
        powerUPActive = true;
        damage = 2;
        powerUPDuration = Time.time + 15f;
    }

    public void ActivateTriggerFinger()
    {
        powerUPActive = true;
        fps = 1f;
        powerUPDuration = Time.time + 15f;
    }

    void ShootPortside()
    {
        RaycastHit hitPortside;

        if (Physics.Raycast(PortCannon.transform.position, PortCannon.transform.forward, out hitPortside, range))
        {
            if (hitPortside.transform.gameObject.tag == "Enemy")
            {
                hitPortside.transform.gameObject.GetComponent<EnemyShipStatus>().DamageEnemy(damage);
            }
        }
    }

    void ShootPortsideRight()
    {
        RaycastHit hitPortside;

        if (Physics.Raycast(PortCannonTriRight.transform.position, PortCannonTriRight.transform.forward, out hitPortside, range))
        {
            if (hitPortside.transform.gameObject.tag == "Enemy")
            {
                hitPortside.transform.gameObject.GetComponent<EnemyShipStatus>().DamageEnemy(damage);
            }
        }
    }

    void ShootPortsideLeft()
    {
        RaycastHit hitPortside;

        if (Physics.Raycast(PortCannonTriLeft.transform.position, PortCannonTriLeft.transform.forward, out hitPortside, range))
        {
            if (hitPortside.transform.gameObject.tag == "Enemy")
            {
                hitPortside.transform.gameObject.GetComponent<EnemyShipStatus>().DamageEnemy(damage);
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
                hitStarboardside.transform.gameObject.GetComponent<EnemyShipStatus>().DamageEnemy(damage);
            }
        }
    }

    void ShootStarboardSideRight()
    {
        RaycastHit hitStarboardside;

        if (Physics.Raycast(StarboardCannonTriRight.transform.position, StarboardCannonTriRight.transform.forward, out hitStarboardside, range))
        {
            if (hitStarboardside.transform.gameObject.tag == "Enemy")
            {
                hitStarboardside.transform.gameObject.GetComponent<EnemyShipStatus>().DamageEnemy(damage);
            }
        }
    }

    void ShootStarboardSideLeft()
    {
        RaycastHit hitStarboardside;

        if (Physics.Raycast(StarboardCannonTriLeft.transform.position, StarboardCannonTriLeft.transform.forward, out hitStarboardside, range))
        {
            if (hitStarboardside.transform.gameObject.tag == "Enemy")
            {
                hitStarboardside.transform.gameObject.GetComponent<EnemyShipStatus>().DamageEnemy(damage);
            }
        }
    }

}
