using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour {

    private Rigidbody rb;
    public float Speed; //speed variable for the player

    // Use this for initialization
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //controls the player on the y axis with the left joystick
        float moveVertical = Input.GetAxis("Vertical");//controls the playre on the x axis with the left joystick

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); //moves the player 
        rb.AddForce(movement * Speed); //adds speed to the player's movement
    }

}
