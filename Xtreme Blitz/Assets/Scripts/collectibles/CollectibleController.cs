using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollectibleController : MonoBehaviour {

    //ParticleSystem meteorParticle;
    public AudioClip CollectibleSound;

    public static CollectibleExplosion Instance;
    //public int ennemyPower;

    //public PlayerController player;




    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    //player bulllets collides with ennemy
    void OnTriggerEnter(Collider other)
    {

            //AudioSource.PlayClipAtPoint(EnnemyExplosionSound, transform.position + new Vector3(0, 0, -40), 1.0f);

            //plays laser shoot sound
            AudioSource.PlayClipAtPoint(CollectibleSound, transform.position);

           // GameObject.Find("UI DATA").GetComponent<uiData>().points += 100.0f;
            CollectibleExplosion.Instance.Explosion(transform.position);
            //Destroy(other.gameObject);
            Destroy(gameObject);
        }

    }


