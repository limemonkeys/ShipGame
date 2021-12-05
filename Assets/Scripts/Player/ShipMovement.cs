using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public Rigidbody Rigidbody;
    int currSpeed = 0;

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
                currSpeed += 3;
            }
            Rigidbody.AddForce(transform.forward * 2);
            currSpeed += 2;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Rigidbody.AddForce(transform.forward * -currSpeed);
            //Rigidbody.AddForce(transform.forward * -1);
            Rigidbody.transform.Rotate(0f, -0.5f, 0f, Space.Self);
            if (currSpeed >= 2) {
                Rigidbody.AddForce(transform.forward * (currSpeed - 2));
                currSpeed = currSpeed - 2;
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            Rigidbody.AddForce(transform.forward * -currSpeed);
            //Rigidbody.AddForce(transform.forward * -1);
            Rigidbody.transform.Rotate(0f, 0.5f, 0f, Space.Self);
            if (currSpeed >= 2)
            {
                Rigidbody.AddForce(transform.forward * (currSpeed - 2));
                currSpeed = currSpeed - 2;
            }
        }

    }
}
