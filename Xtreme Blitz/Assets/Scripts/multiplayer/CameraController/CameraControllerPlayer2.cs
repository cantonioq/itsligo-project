/*
File            CameraControllerPlayer2.cs
Author          Antonio Quesnel
Date            11/10/2017  
Version         1.0 
Description:    
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerPlayer2 : MonoBehaviour {

    public GameObject player2;
    public float turnSpeed = 1.0f;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player2.transform.position;
    }

    void LateUpdate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("HorizontalRight2") * turnSpeed, Vector3.up) * offset;
        transform.position = player2.transform.position + offset;
        transform.LookAt(player2.transform.position);

    }
}