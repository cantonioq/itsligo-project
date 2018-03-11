/*
 Authour: Shay Pitcher

 Function: Rotates the first three metal barrels in single player level 2.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBarrel : MonoBehaviour
{
    public float Rotatespeed = 10.0f;
	
	void Update ()
    {
        transform.Rotate(Vector3.down, Rotatespeed * Time.deltaTime);
    }
}
