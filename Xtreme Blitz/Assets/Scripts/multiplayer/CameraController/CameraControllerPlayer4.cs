/*
File            CameraControllerPlayer4.cs
Author          Antonio Quesnel
Date            11/10/2017  
Version         1.0 
Description:    
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerPlayer4 : MonoBehaviour {

    public GameObject player4;
    public float turnSpeed = 1.0f;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player4.transform.position;
    }

    void LateUpdate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("HorizontalRight4") * turnSpeed, Vector3.up) * offset;
        transform.position = player4.transform.position + offset;
        transform.LookAt(player4.transform.position);

    }
}
