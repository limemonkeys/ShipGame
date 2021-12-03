using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public Rigidbody Rigidbody;

    // Start is called before the first frame update
    public void Awake()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W)) {
            Rigidbody.AddForce(transform.forward * 2);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Rigidbody.AddForce(transform.forward * -1);
            Rigidbody.transform.Rotate(0f, -0.5f, 0f, Space.Self);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Rigidbody.AddForce(transform.forward * -1);
            Rigidbody.transform.Rotate(0f, 0.5f, 0f, Space.Self);
        }

    }
}
