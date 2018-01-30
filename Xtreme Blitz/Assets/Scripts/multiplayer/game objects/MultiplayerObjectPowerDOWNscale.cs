/*
File            MultiplayerObjectPowerDOWNscale.cs
Author          Antonio Quesnel
Date            11/10/2017  
Version         1.0 
Description:    
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerObjectPowerDOWNscale : MonoBehaviour {

    public AudioSource audioSource;
    public static PowerDownParticle Instance;

    void OnTriggerEnter(Collider other)
    {
        audioSource.Play();

        if (other.gameObject.name == "Player1")
        {
            GameObject.Find("Player1").GetComponent<PlayerController1>().SizeMassMinus = true;
        }

        if (other.gameObject.name == "Player2")
        {
            GameObject.Find("Player2").GetComponent<PlayerController2>().SizeMassMinus = true;
        }

        if (other.gameObject.name == "Player3")
        {
            GameObject.Find("Player3").GetComponent<PlayerController3>().SizeMassMinus = true;
        }

        if (other.gameObject.name == "Player4")
        {
            GameObject.Find("Player4").GetComponent<PlayerController4>().SizeMassMinus = true;
        }

        other.transform.localScale -= new Vector3(0.10f, 0.10f, 0.10f); // increases values still in development 
        Destroy(gameObject);
        GameObject.Find("Collectible Multiplayer PowerDOWN").GetComponent<RandomPositionPowerupCollectibles>().numberOfObjects += 1;

        PowerDownParticle.Instance.Explosion(transform.position);
    }
}
