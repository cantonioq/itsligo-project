using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerPlayer1 : MonoBehaviour {

    public GameObject player1;
    public float turnSpeed = 1.0f;

    private Vector3 offset;

    void Start()
    {
        offset = transform.position - player1.transform.position;
    }

    void LateUpdate()
    {
        offset = Quaternion.AngleAxis(Input.GetAxis("HorizontalRight") * turnSpeed, Vector3.up) * offset;
        transform.position = player1.transform.position + offset;
        transform.LookAt(player1.transform.position);

    }
}