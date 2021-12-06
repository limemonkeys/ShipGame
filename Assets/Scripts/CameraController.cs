//https://stackoverflow.com/questions/56382451/how-to-rotate-camera-around-player-in-unity-c-sharp

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float turnSpeed = 5.0f;
    public GameObject player;

    private Transform playerTransform;
    private Vector3 offset;
    public float yOffset = 10.0f;
    public float zOffset = 10.0f;

    void Start()
    {
        playerTransform = player.transform;
        offset = new Vector3(playerTransform.position.x, playerTransform.position.y + yOffset, playerTransform.position.z - zOffset);
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
        transform.position = playerTransform.position + offset;
        transform.LookAt(playerTransform.position);
    }
}