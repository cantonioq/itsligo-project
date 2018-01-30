using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController4 : MonoBehaviour {

    private Rigidbody rb;
    public float Speed; //speed variable for the player
    public GameObject Camera4;
    public bool SizeMassPlus = false;
    public bool SizeMassMinus = false;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        increaseSpeedMass();
        decreaseSpeedMass();
    }

    private void decreaseSpeedMass()
    {
        if (SizeMassMinus == true)
        {
            if (Speed > 7.9f)
            {
                rb.mass -= 5.0f;
                Speed -= 3.0f;
            }
            SizeMassMinus = false;
        }
    }

    private void increaseSpeedMass()
    {
        if (SizeMassPlus == true)
        {
            if (Speed < 60)
            {
                rb.mass += 5.0f;
                Speed += 3.0f;
            }
            SizeMassPlus = false;
        }
    }

    void FixedUpdate()
    {
        Vector3 fromCameraToMe = transform.position - Camera4.transform.position;
        fromCameraToMe.y = 0;
        fromCameraToMe.Normalize();

        float moveHorizontal = Input.GetAxis("Horizontal4"); //controls the player on the y axis with the left joystick
        float moveVertical = Input.GetAxis("Vertical4");//controls the playre on the x axis with the left joystick

        //Vector3 movement = new Vector3(moveHorizontal , 0.0f, moveVertical); //moves the player 
        Vector3 movement = (fromCameraToMe * moveVertical + Camera4.transform.right * moveHorizontal) * Speed;
        rb.AddForce(movement * Speed); //adds speed to the player's movement

    }


}