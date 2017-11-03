using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerRotatingObject : MonoBehaviour {

    public int y;
    public int z;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, y, z * Time.deltaTime); //rotates 50 degrees per second around z axis
    }
}
