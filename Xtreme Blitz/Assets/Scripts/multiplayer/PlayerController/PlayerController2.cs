using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour {

    private Rigidbody rb;
    public float Speed; //speed variable for the player
    public GameObject Camera2;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {

    }

    void FixedUpdate()
    {
        Vector3 fromCameraToMe = transform.position - Camera2.transform.position;
        fromCameraToMe.y = 0;
        fromCameraToMe.Normalize();

        float moveHorizontal = Input.GetAxis("Horizontal2"); //controls the player on the y axis with the left joystick
        float moveVertical = Input.GetAxis("Vertical2");//controls the playre on the x axis with the left joystick

        //Vector3 movement = new Vector3(moveHorizontal , 0.0f, moveVertical); //moves the player 
        Vector3 movement = (fromCameraToMe * moveVertical + Camera2.transform.right * moveHorizontal) * Speed;
        rb.AddForce(movement * Speed); //adds speed to the player's movement

    }


}