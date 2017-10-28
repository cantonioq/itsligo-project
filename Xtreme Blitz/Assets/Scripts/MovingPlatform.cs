using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    //public float movingSpeed = 10.0f;
	void Update ()
    {
        transform.Translate(Vector3.left * Time.deltaTime);
	}
}
