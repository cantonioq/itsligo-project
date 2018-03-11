/*
 Authour: Shay Pitcher

 Function: The main camera follows the player and can be rotated left,right, and down.

*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    public float cameraTurnSpeed = 4.0f;

    private Vector3 offset;
    float x; // variable for the camera's x axis
    float y; // variable for the camera's y axis

    // Use this for initialization
    void Start ()
    {
        offset = transform.position - player.transform.position;
    }

    void Update()
    {
        x += Input.GetAxis("CameraHorizontal"); //controls the camera's x axis using the right joystick
        y += Input.GetAxis("CameraVertical"); //controls the camera's y axis using the right joystick
    }

    void LateUpdate ()
    {
        transform.position = player.transform.position + offset;
        transform.LookAt(player.transform.position);

        offset = Quaternion.AngleAxis(Input.GetAxis("HorizontalRight") * cameraTurnSpeed, Vector3.up) * offset;

    }
}
