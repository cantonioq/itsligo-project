using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killstreakSeagull : MonoBehaviour {

    public AudioSource seagulls;
    public float time = 30.0f;
    //public GameObject[] seagulls;
    public float speed;
    bool soundSwitch = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        time -= Time.deltaTime;

        if (time < 0.1f)
        {
            soundSwitch = true;
            transform.Translate(Vector3.left * Time.deltaTime * speed);

            if (time < -37.0f)
            {
                transform.position  = new Vector3(4000.0f, transform.position.y, transform.position.z);
                time += Random.Range(50.0f, 80.0f);
                Debug.Log("got target");
                soundSwitch = false;
            }
        }

        if (time >= -1.0f)
        {
            seagulls.volume = 0.1f;
        }

        else if (time >= -3.0f)
        {
            seagulls.volume = 0.3f;
        }

        else if (time >= -6.0f)
        {
            seagulls.volume = 0.4f;
        }

        else if (time >= -9.0f)
        {
            seagulls.volume = 0.5f;
        }

        else if (time >= -27.0f)
        {
            seagulls.volume = 0.4f;
        }

        else if (time >= -31.0f)
        {
            seagulls.volume = 0.25f;
        }

        else if (time >= -34.0f)
        {
            seagulls.volume = 0.15f;
        }

        else
        {
            seagulls.volume = 0.0f;
        }

        //to activate and deactivate the seagull sound 
        if (soundSwitch == true && seagulls.isPlaying == false)
        {
            seagulls.Play();
        }
        else if (soundSwitch == false && seagulls.isPlaying == true)
        {
            seagulls.Stop();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        seagulls.Play();
    }



}
