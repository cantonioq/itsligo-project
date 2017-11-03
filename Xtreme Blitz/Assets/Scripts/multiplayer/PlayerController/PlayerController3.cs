﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController3 : MonoBehaviour {

    private Rigidbody rb;
    public float Speed; //speed variable for the player
    public GameObject Camera3;

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
        Vector3 fromCameraToMe = transform.position - Camera3.transform.position;
        fromCameraToMe.y = 0;
        fromCameraToMe.Normalize();

        float moveHorizontal = Input.GetAxis("Horizontal3"); //controls the player on the y axis with the left joystick
        float moveVertical = Input.GetAxis("Vertical3");//controls the playre on the x axis with the left joystick

        //Vector3 movement = new Vector3(moveHorizontal , 0.0f, moveVertical); //moves the player 
        Vector3 movement = (fromCameraToMe * moveVertical + Camera3.transform.right * moveHorizontal) * Speed;
        rb.AddForce(movement * Speed); //adds speed to the player's movement

    }


}