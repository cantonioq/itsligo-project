using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerCollectiblePowerUpScale : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {	
	}

    void OnTriggerEnter(Collider other)
    {

        other.transform.localScale += new Vector3(0.25f,0.25f, 0.25f); // increases values still in development 
        Destroy(gameObject);
    }
}
