using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public Rigidbody Rigidbody;
    int currSpeed = 0;

    float turnSpeed = 0.5f;
    int accelSpeed = 2;

    public bool megaFuelActive;
    public float megaFuelDuration = 0f;

    void Update() 
    {
        if (megaFuelActive)
        {
            megaFuelDuration -= Time.deltaTime;
            if (megaFuelDuration < 0f)
            {
                accelSpeed /= 2;
                megaFuelActive = false;
                megaFuelDuration = 0f;

            }
        }
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
            currSpeed += accelSpeed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            Rigidbody.AddForce(transform.forward * -currSpeed);
            //Rigidbody.AddForce(transform.forward * -1);
            Rigidbody.transform.Rotate(0f, -turnSpeed, 0f, Space.Self);
            if (currSpeed >= 2) {
                Rigidbody.AddForce(transform.forward * (currSpeed - 2));
                currSpeed = currSpeed - 2;
            }
        }

        else if (Input.GetKey(KeyCode.D))
        {
            Rigidbody.AddForce(transform.forward * -currSpeed);
            //Rigidbody.AddForce(transform.forward * -1);
            Rigidbody.transform.Rotate(0f, turnSpeed, 0f, Space.Self);
            if (currSpeed >= 2)
            {
                Rigidbody.AddForce(transform.forward * (currSpeed - 2));
                currSpeed = currSpeed - 2;
            }
        }

    }

    public void ActivateMegaFuel()
    {
        megaFuelActive = true;
        accelSpeed *= 2;
        megaFuelDuration = Time.time + 15f;
    }
}
