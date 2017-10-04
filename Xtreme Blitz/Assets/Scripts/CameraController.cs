using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    public GameObject player;
    public Transform lookAt;
    public Transform cameraTransform;

    private Vector3 offset;
    private Camera camera;

	// Use this for initialization
	void Start ()
    {
        cameraTransform = transform;
        camera = Camera.main;
        //offset = transform.position - lookAt.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        cameraTransform.position = lookAt.position;
        
        //transform.position = player.transform.position + offset;
        //transform.Rotate(Vector3.up, test * Time.deltaTime);
        

    }
}
