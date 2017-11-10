/*
File            MultiplayerCollectiblePowerUpScale.cs
Author          Antonio Quesnel
Date            11/10/2017  
Version         1.0 
Description:    
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerCollectiblePowerUpScale : MonoBehaviour {

    int newCollectible = 0;

    //public AudioClip CollectibleSound; 

    public AudioSource audioSource;
    public static PowerUpParticle Instance;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {	
	}

    void OnTriggerEnter(Collider other)
    {
        //AudioSource.PlayClipAtPoint(CollectibleSound, transform.position);
        audioSource.Play();

        other.transform.localScale += new Vector3(0.20f,0.20f, 0.20f); // increases values still in development 
        Destroy(gameObject);
        newCollectible += 1;
        GameObject.Find("Collectible Multiplayer Powerup").GetComponent<RandomPositionPowerupCollectibles>().numberOfObjects += 1;

        PowerUpParticle.Instance.Explosion(transform.position);
    }
}
