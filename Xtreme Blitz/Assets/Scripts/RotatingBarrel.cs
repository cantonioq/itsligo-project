using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingBarrel : MonoBehaviour
{
    public float Rotatespeed = 10.0f;
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(Vector3.down, Rotatespeed * Time.deltaTime);
    }
}
