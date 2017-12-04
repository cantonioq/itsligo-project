using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdPooCollision : MonoBehaviour {

    public AudioSource audioScream;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            audioScream.Play();
            other.transform.localScale -= new Vector3(0.20f, 0.20f, 0.20f);
        }

    }

}
