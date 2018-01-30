/*
File            PowerDownParticle.cs
Author          Antonio Quesnel
Date            11/10/2017  
Version         1.0 
Description:    
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerDownParticle : MonoBehaviour {

    public static PowerDownParticle Instance;

    //public ParticleSystem smokeEffect;
    public ParticleSystem PowerDownCollectible;

    void Awake()
    {
        // Register the singleton
        if (Instance != null)
        {
           // Debug.LogError("Multiple instances of SpecialEffectsHelper!");
        }

        Instance = this;
    }

    public void Explosion(Vector3 position)
    {

        instantiate(PowerDownCollectible, position);
    }

    private ParticleSystem instantiate(ParticleSystem prefab, Vector3 position)
    {
        ParticleSystem newParticleSystem = Instantiate(
          prefab,
          position,
          Quaternion.identity
        ) as ParticleSystem;

        // Make sure it will be destroyed
        Destroy(
          newParticleSystem.gameObject,
          newParticleSystem.startLifetime
        );

        return newParticleSystem;
    }
}
