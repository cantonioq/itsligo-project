using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class multiplayerController : MonoBehaviour {

    private Rigidbody rb;
    public float Speed; //speed variable for the player

    public Object player1;
    public Object player2;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void FixedUpdate()
    {

        if (player1)
        {
            float moveHorizontal = Input.GetAxis("Horizontal"); //controls the player on the y axis with the left joystick
            float moveVertical = Input.GetAxis("Vertical");//controls the playre on the x axis with the left joystick


            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); //moves the player 
            rb.AddForce(movement * Speed); //adds speed to the player's movement
        }

        if (player2)

        {
            float moveHorizontal = Input.GetAxis("Horizontal2"); //controls the player on the y axis with the left joystick
            float moveVertical = Input.GetAxis("Vertical2");//controls the playre on the x axis with the left joystick


            Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical); //moves the player 
            rb.AddForce(movement * Speed); //adds speed to the player's movement
        }

        else
        {
            Debug.Log("nothing");
        }
    }

}
