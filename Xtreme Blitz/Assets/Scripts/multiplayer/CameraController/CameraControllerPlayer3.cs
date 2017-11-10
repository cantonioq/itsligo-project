/*
File            CameraControllerPlayer3.cs
Author          Antonio Quesnel
Date            11/10/2017  
Version         1.0 
Description:    
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerPlayer3 : MonoBehaviour {

    public GameObject player3;
    public float turnSpeed = 1.0f;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player3.transform.position;
    }

    void LateUpdate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("HorizontalRight3") * turnSpeed, Vector3.up) * offset;
        transform.position = player3.transform.position + offset;
        transform.LookAt(player3.transform.position);

    }
}