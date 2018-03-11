/*
 Authour: Shay Pitcher

 Function: Allows the player to move and be controlled using a gamepad.

*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody rb;
    public float Speed; //speed variable for the player
    public GameObject mainCamera;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}


    void FixedUpdate()
    {
        Vector3 fromCameraToMe = transform.position - mainCamera.transform.position;
        fromCameraToMe.y = 0;
        fromCameraToMe.Normalize();

        float moveHorizontal = Input.GetAxis("Horizontal"); //controls the player on the y axis with the left joystick
        float moveVertical = Input.GetAxis("Vertical");//controls the playre on the x axis with the left joystick

        Vector3 movement = (fromCameraToMe * moveVertical + mainCamera.transform.right * moveHorizontal) * Speed;
         
        rb. AddForce(movement * Speed); //adds speed to the player's movement
    }

}
