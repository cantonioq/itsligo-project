﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerRotatingObject : MonoBehaviour {

    public int speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, speed * Time.deltaTime); //rotates 50 degrees per second around z axis
    }
}
