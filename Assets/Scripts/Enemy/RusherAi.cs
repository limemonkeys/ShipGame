using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RusherAi : MonoBehaviour
{

    public int finderDist = 50;
    int MoveSpeed = 4;
    public Transform Player;
    public Transform shipBow;

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
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Terrain")
        {
            transform.Translate(1, 0, 0);
        }
    }
    void OnTriggerExit(Collider other)
    {
        triggered = false;
    }
    void Die()
    {

    }
}