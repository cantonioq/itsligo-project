using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplayerObjectPowerDOWNscale : MonoBehaviour {

    public AudioSource audioSource;
    public static PowerDownParticle Instance;

    void OnTriggerEnter(Collider other)
    {
        audioSource.Play();

        other.transform.localScale -= new Vector3(0.20f, 0.20f, 0.20f); // increases values still in development 
        Destroy(gameObject);
        GameObject.Find("Collectible Multiplayer PowerDOWN").GetComponent<RandomPositionPowerupCollectibles>().numberOfObjects += 1;

        PowerDownParticle.Instance.Explosion(transform.position);
    }
}
