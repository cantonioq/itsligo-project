﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetaCamera : MonoBehaviour {

    public float turnSpeed = 4.0f;
    public Transform player;

    public Vector3 offset;

    void Start()
    {
        offset = new Vector3(player.position.x, player.position.y + 0.0f, player.position.z - 10.0f);
    }

    void LateUpdate()
    {
        //offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
        offset = Quaternion.AngleAxis(Input.GetAxis("HorizontalRight") * turnSpeed, Vector3.up) * offset;
        transform.position = player.position + offset;
        transform.LookAt(player.position);
    }
}