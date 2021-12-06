using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public int currSpeed = 0;
    public Transform shipBow;

    // Start is called before the first frame update
    public void Awake()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)) {
            if (currSpeed <= 0)
            {
                Rigidbody.AddForce(transform.forward * 3);
                currSpeed += 5;
            }
            Rigidbody.AddForce(transform.forward * 2);
            currSpeed += 2;
        }

        if (Input.GetKey(KeyCode.A))
        {
            if (currSpeed > 0)
            {
                Rigidbody.AddForce(transform.forward * -currSpeed);
            }
            //Rigidbody.AddForce(transform.forward * -1);
            Rigidbody.transform.Rotate(0f, -0.6f, 0f, Space.Self);
            if (currSpeed >= 1) {
                Rigidbody.AddForce(transform.forward * (currSpeed - 1));
                currSpeed = currSpeed - 1;
            }
        }

        else if (Input.GetKey(KeyCode.D))
        {
            if (currSpeed > 0)
            {
                Rigidbody.AddForce(transform.forward * -currSpeed);
            }
            //Rigidbody.AddForce(transform.forward * -1);
            Rigidbody.transform.Rotate(0f, 0.6f, 0f, Space.Self);
            if (currSpeed >= 1)
            {
                Rigidbody.AddForce(transform.forward * (currSpeed - 1));
                currSpeed = currSpeed - 1;
            }
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Water")
        {
            currSpeed = 0;
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
}
