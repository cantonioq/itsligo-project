using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerPlayer3 : MonoBehaviour {

    private float turnSpeed = 3.0f;
    public Transform player;

    public Vector3 offset;

    void Start()
    {
        offset = new Vector3(player.position.x, player.position.y, player.position.z);
    }

    void LateUpdate()
    {
        //offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
        offset = Quaternion.AngleAxis(Input.GetAxis("HorizontalRight3") * turnSpeed, Vector3.up) * offset;
        transform.position = player.position + offset;
        transform.LookAt(player.position);

    }
}
