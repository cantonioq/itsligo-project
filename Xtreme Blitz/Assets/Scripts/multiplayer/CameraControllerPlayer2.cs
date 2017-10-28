using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerPlayer2 : MonoBehaviour {

    private float turnSpeed = 3.0f;
    public Transform player;

    public Vector3 offset;

    void Start()
    {
        offset = new Vector3(player.position.x + 36.0f, player.position.y - 240.0f, player.position.z - 124.0f);
    }

    void LateUpdate()
    {
        //offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * turnSpeed, Vector3.up) * offset;
        offset = Quaternion.AngleAxis(Input.GetAxis("HorizontalRight2") * turnSpeed, Vector3.up) * offset;
        transform.position = player.position + offset;
        transform.LookAt(player.position);

    }
}
