using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    public Transform lookAt;
    public Transform cameraTransform;

    private Vector3 offset;
    private Camera camera;
    float x; // variable for the camera's x axis
    float y; // variable for the camera's y axis

    // Use this for initialization
    void Start ()
    {
        cameraTransform = transform;
        camera = Camera.main;
        //offset = transform.position - lookAt.transform.position;
	}

    void Update()
    {
        x += Input.GetAxis("CameraHorizontal"); //controls the camera's x axis using the right joystick
        y += Input.GetAxis("CameraVertical"); //controls the camera's y axis using the right joystick
    }

    // Update is called once per frame
    void LateUpdate ()
    {
        cameraTransform.position = lookAt.position;
        
        //transform.position = lookAt.transform.position + offset;
        //transform.Rotate(Vector3.up, test * Time.deltaTime);           

        transform.rotation = Quaternion.Euler(x, y, 0); //allows the camera to be rotated on the x and y axis
        

    }
}
