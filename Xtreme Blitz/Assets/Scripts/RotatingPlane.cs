/*
 Authour: Shay Pitcher

 Function: Rotates the large metal platform in single player level 2.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingPlane : MonoBehaviour
{
    public float rotateSpeed = 5.0f; //how fast the platform is rotated
	
	void Update ()
    {
        transform.Rotate(Vector3.forward, rotateSpeed * Time.deltaTime); //rotates the platform on its x-axis
	}
}
