using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretAI : MonoBehaviour
{
    int finderDist = 100;
    int shootDist = 50;

    public Transform Player;
    public Camera turretCam;
    public ParticleSystem turretFlash;
    bool firstShot = false;
    public float range = 60f;
    public float fps = 10f;
    public float reloadingTur = 0f;
    RaycastHit hitCannon;
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
            if (!firstShot)
            {
                firstShot = true;
                reloadingTur = Time.time + (fps / 2);
            }
            if (Time.time >= reloadingTur)
            {
                reloadingTur = Time.time + fps;
                turretFlash.Play();
                ShootCannon(hitCannon);
            }
        }
        
    }
    void ShootCannon(RaycastHit hitCannon)
    {

        if (Physics.Raycast(turretCam.transform.position, turretCam.transform.forward, out hitCannon, range))
        {
            if (hitCannon.transform.gameObject.tag == "Player")
            {
                hitCannon.transform.gameObject.GetComponent<ShipStatus>().DamagePlayer(1);

            }
        }
    }
}